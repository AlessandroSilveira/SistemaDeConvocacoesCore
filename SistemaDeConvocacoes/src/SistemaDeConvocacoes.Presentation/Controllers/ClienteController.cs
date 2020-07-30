using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Models;
using SistemaDeConvocacoes.Presentation.Models;

namespace SistemaDeConvocacoes.Presentation.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class ClienteController : Controller
    {
        private readonly IClienteAppService _clienteAppService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public ClienteController(IClienteAppService clienteAppService, UserManager<ApplicationUser> userManager, IWebHostEnvironment webHostEnvironment)
        {
            _clienteAppService = clienteAppService;
            _userManager = userManager;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> IndexAsync()
        {
            return View(await _clienteAppService.GetAllAsync());
        }

        public async Task<IActionResult> DetailsAsync(Guid? id)
        {
            if (id.Equals(null))
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            var clienteViewModel = await _clienteAppService.GetByIdAsync(Guid.Parse(id.ToString()));
            if (clienteViewModel.Equals(null))
                return NotFound();

            return View(clienteViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(ClienteViewModel clienteViewModel, IFormFile Imagem)
        {
            if (!ModelState.IsValid) 
                return View(clienteViewModel);

            clienteViewModel.ClienteId = Guid.NewGuid();
            clienteViewModel.Imagem = Imagem.FileName;
            clienteViewModel.Ativo = true;

            var cliente = await _clienteAppService.AddAsync(clienteViewModel);
           
           
            if(cliente != null)
            {
                SalvarImagemCliente(Imagem, cliente);

                return RegistarClienteParaFazerLoginAsync(clienteViewModel, out IActionResult actionResult)
                    ? actionResult
                    : RedirectToAction("Index");
            }
            else
            {
               return RedirectToAction("Index");
            }
        }

        private bool RegistarClienteParaFazerLoginAsync(ClienteViewModel clienteViewModel, out IActionResult actionResult)
        {           
            var user = new ApplicationUser
            {
                Id = clienteViewModel.ClienteId.ToString(),
                UserName = clienteViewModel.Email,
                Email = clienteViewModel.Email
            };
            var result = _userManager.CreateAsync(user, clienteViewModel.Password).Result;

            if (!result.Succeeded)
            {
                actionResult = RedirectToAction("Index");
                return false;
            }

            user = _userManager.FindByEmailAsync(clienteViewModel.Email).Result;
            var addrole = _userManager.AddToRoleAsync(user, RolesNames.ROLE_CLIENTE).Result;

            actionResult = null;
            return true;
        }

        private void SalvarImagemCliente(IFormFile file, ClienteViewModel cliente)
        {
            if (file == null) 
                return;

            var webRootPath = _webHostEnvironment.WebRootPath;
            var contentRootPath = _webHostEnvironment.ContentRootPath;
            var path = string.Empty;

            path = Path.Combine(webRootPath, "Images");

            var strName = file.FileName.Split('.');
            var strExt = strName[strName.Count() - 1];
            var pathSave = $"{path}{cliente.ClienteId}.{strExt}";

            using var fileStream = new FileStream(pathSave, FileMode.Create);
            file.CopyToAsync(fileStream);
        }

        public async Task<IActionResult> EditAsync(Guid? id)
        {
            if (id.Equals(null))
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            var clienteViewModel = await _clienteAppService.GetByIdAsync(Guid.Parse(id.ToString()));

            if (clienteViewModel.Equals(null))
                return NotFound();

            return View(clienteViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(ClienteViewModel clienteViewModel)
        {
            if (!ModelState.IsValid) 
                return View(clienteViewModel);

            await _clienteAppService.UpdateAsync(clienteViewModel);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAsync(Guid? id)
        {
            if (id.Equals(null))
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            var clienteViewModel = await _clienteAppService.GetByIdAsync(Guid.Parse(id.ToString()));

            if (clienteViewModel.Equals(null))
                return NotFound();

            return View(clienteViewModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedAsync(Guid id)
        {
            await _clienteAppService.RemoveAsync(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _clienteAppService.Dispose();

            base.Dispose(disposing);
        }
    }
}