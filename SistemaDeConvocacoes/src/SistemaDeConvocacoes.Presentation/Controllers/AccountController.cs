using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Models;
using SistemaDeConvocacoes.Presentation.ViewModels.AccountViewModels;

namespace SistemaDeConvocacoes.Presentation.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger _logger;
        private readonly IPrimeiroAcessoAppService _primeiroAcessoAppService;
        private readonly IConvocadoAppService _convocadoAppService;

        public AccountController(
           UserManager<ApplicationUser> userManager,
                    SignInManager<ApplicationUser> signInManager,
                    ILogger<AccountController> logger, 
                    IPrimeiroAcessoAppService primeiroAcessoAppService, 
                    IConvocadoAppService convocadoAppService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _primeiroAcessoAppService = primeiroAcessoAppService;
            _convocadoAppService = convocadoAppService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    _logger.LogInformation("User created a new account with password.");
                    return RedirectToLocal(returnUrl);
                }
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, true);

            if (result.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                var roles = await _userManager.GetRolesAsync(user);
                if (roles[0] == "Convocado")
                {
                    VerificaPrimeiroAcessoAsync(model);
                }

                return RedirectToLocal(returnUrl);
            }
            else
            {
                ModelState.AddModelError("", "Login ou Senha incorretos.");
                return View(model);
            }

        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Lockout()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        private async Task VerificaPrimeiroAcessoAsync(LoginViewModel model)
        {
            var primeiroAcesso = await _primeiroAcessoAppService.SearchAsync(a => a.Email.Equals(model.Email));

            var dadosConvocado = _convocadoAppService.SearchAsync(a => a.Email.Equals(model.Email)).Result.FirstOrDefault();

            var primeiroAcessoViewModel = new PrimeiroAcessoViewModel
            {
                PrimeiroAcessoId = Guid.NewGuid(),
                Email = model.Email,
                ConvocadoId = dadosConvocado.ConvocadoId,
                Data = DateTime.Now
            };

            if (!primeiroAcesso.Any())
                await _primeiroAcessoAppService.AddAsync(primeiroAcessoViewModel);
        }

        ////
        //// GET: /Account/ForgotPassword
        //[AllowAnonymous]
        //public ActionResult ForgotPassword()
        //{
        //    return View();
        //}

        ////
        //// POST: /Account/ForgotPassword
        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> ForgotPassword(ForgotPasswordViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = await _userManager.FindByNameAsync(model.Email);

        //        if (user == null)
        //            return View("EmailNaoCadastrado");

        //        var code = await _userManager.GeneratePasswordResetTokenAsync(user.Id);
        //        var callbackUrl = Url.Action("ResetPassword", "Account", new { userId = user.Id, code },
        //            Request.Url.Scheme);
        //        await _userManager.SendEmailAsync(user.Id, "Esqueci minha senha",
        //            "Por favor altere sua senha clicando aqui: <a href='" + callbackUrl + "'></a>");
        //        ViewBag.Link = callbackUrl;
        //        ViewBag.Status = "DEMO: Caso o link não chegue: ";
        //        ViewBag.LinkAcesso = callbackUrl;
        //        return View("ForgotPasswordConfirmation");
        //    }

        //    // No caso de falha, reexibir a view.
        //    return View(model);
        //}

        ////
        //// GET: /Account/ForgotPasswordConfirmation
        //[AllowAnonymous]
        //public ActionResult ForgotPasswordConfirmation()
        //{
        //    return View();
        //}

        ////
        //// GET: /Account/ResetPassword
        //[AllowAnonymous]
        //public ActionResult ResetPassword(string code)
        //{
        //    return code == null ? View("Error") : View();
        //}

        ////
        //// POST: /Account/ResetPassword
        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> ResetPassword(ResetPasswordViewModel model)
        //{
        //    if (!ModelState.IsValid) return View(model);
        //    var user = await _userManager.FindByNameAsync(model.Email);
        //    if (user == null) return RedirectToAction("ResetPasswordConfirmation", "Account");
        //    var result = await _userManager.ResetPasswordAsync(user.Id, model.Code, model.Password);
        //    if (result.Succeeded) return RedirectToAction("ResetPasswordConfirmation", "Account");
        //    AddErrors(result);
        //    return View();
        //}

        ////
        //// GET: /Account/ResetPasswordConfirmation
        //[AllowAnonymous]
        //public ActionResult ResetPasswordConfirmation()
        //{
        //    return View();
        //}

        ////
        //// POST: /Account/LogOff
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult LogOff()
        //{
        //    AuthenticationManager.SignOut();
        //    return RedirectToAction("Login", "Account");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        if (_userManager != null)
        //        {
        //            _userManager.Dispose();
        //            _userManager = null;
        //        }

        //        if (_signInManager != null)
        //        {
        //            _signInManager.Dispose();
        //            _signInManager = null;
        //        }
        //    }

        //    base.Dispose(disposing);
        //}

        //private void AdicionarAdministrador(RegisterViewModel model)
        //{
        //    var admin = new Admin2ViewModel
        //    {
        //        Nome = model.Nome,
        //        Ativo = true,
        //        Email = model.Email,
        //        Empresa = model.Empresa,
        //        Cnpj = model.Cnpj,
        //        Telefone = model.Telefone,
        //        Senha = model.Password,
        //        Imagem = model.Imagem
        //    };

        //    _adminAppService.Add(admin);
        //}



        // Used for XSRF protection when adding external logins
        #region Helpers

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        #endregion

    }
}