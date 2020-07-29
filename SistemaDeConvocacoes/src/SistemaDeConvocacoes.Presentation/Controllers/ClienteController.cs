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

        public ActionResult Index()
        {
            return View(_clienteAppService.GetAll());
        }

        public ActionResult Details(Guid? id)
        {
            if (id.Equals(null))
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            var clienteViewModel = _clienteAppService.GetById(Guid.Parse(id.ToString()));
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
        public async Task<ActionResult> CreateAsync(ClienteViewModel clienteViewModel, IFormFile Imagem)
        {
            if (!ModelState.IsValid) 
                return View(clienteViewModel);

            clienteViewModel.ClienteId = Guid.NewGuid();
            var cliente = _clienteAppService.Add(clienteViewModel);

            SalvarImagemCliente(Imagem, cliente);

            return RegistarClienteParaFazerLoginAsync(cliente, out ActionResult actionResult)
                ? actionResult
                : RedirectToAction("Index");
        }

        private bool RegistarClienteParaFazerLoginAsync(ClienteViewModel clienteViewModel, out ActionResult actionResult)
        {
            var cliente = _clienteAppService.Search(a => a.Email.Equals(clienteViewModel.Email)).FirstOrDefault();
            var user = new ApplicationUser
            {
                Id = cliente.ClienteId.ToString(),
                UserName = clienteViewModel.Email,
                Email = clienteViewModel.Email
            };
            var result = _userManager.AddPasswordAsync(user, clienteViewModel.Password).Result;

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

        public ActionResult Edit(Guid? id)
        {
            if (id.Equals(null))
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            var clienteViewModel = _clienteAppService.GetById(Guid.Parse(id.ToString()));
            if (clienteViewModel.Equals(null))
                return NotFound();

            return View(clienteViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel clienteViewModel)
        {
            if (!ModelState.IsValid) return View(clienteViewModel);
            _clienteAppService.Update(clienteViewModel);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid? id)
        {
            if (id.Equals(null))
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            var clienteViewModel = _clienteAppService.GetById(Guid.Parse(id.ToString()));
            if (clienteViewModel.Equals(null))
                return NotFound();

            return View(clienteViewModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _clienteAppService.Remove(id);
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