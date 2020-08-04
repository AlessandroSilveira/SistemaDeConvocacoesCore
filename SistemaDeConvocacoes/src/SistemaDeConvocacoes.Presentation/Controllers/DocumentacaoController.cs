using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;

namespace SistemaDeConvocacoes.Presentation.Controllers
{
    [Authorize(Roles = "Cliente")]
    public class DocumentacaoController : Controller
    {
        private readonly IDocumentacaoAppService _documentacaoAppService;
        private readonly IProcessoAppService _processoAppService;
        private readonly IConfiguration _configuration;

        public DocumentacaoController(
            IDocumentacaoAppService documentacaoAppService,
            IProcessoAppService processoAppService, IConfiguration configuration)
        {
            _documentacaoAppService = documentacaoAppService;
            _processoAppService = processoAppService;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index(Guid Id)
        {
            ViewBag.ProcessoId = Id;
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(Id);
            return View(await _documentacaoAppService.GetAllAsync());
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var documentacaoViewModel = await _documentacaoAppService.GetByIdAsync(id);
            return documentacaoViewModel == null ? (ActionResult) NotFound() : View(documentacaoViewModel);
        }

        public async Task<IActionResult> Create(Guid Id)
        {
            ViewBag.ProcessoId = Id;
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(Id);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DocumentacaoViewModel documentacaoViewModel)
        {
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(documentacaoViewModel.ProcessoId);
            documentacaoViewModel.DataCriacao = DateTime.Now;

            if (!ModelState.IsValid) 
                return View(documentacaoViewModel);

            var path = SalvarArquivoConvocados(documentacaoViewModel);

            if (string.IsNullOrEmpty(path)) 
                return RedirectToAction("Index");

            documentacaoViewModel.Path = path;
            await _documentacaoAppService.AddAsync(documentacaoViewModel);

            return RedirectToAction("Index", new {Id = documentacaoViewModel.ProcessoId});
        }

        private string SalvarArquivoConvocados(DocumentacaoViewModel documentacaoViewModel)
        {
            var pathArquivo = _configuration.GetSection("SistemaDeConvocacoesDocs").Value;
            pathArquivo = pathArquivo.ToString().Replace(@"\\", @"\");
            var arquivo = Request.Form.Files[0];
            if (arquivo == null)
                return string.Empty;

            var nomeArquivo = Path.GetFileName(arquivo.FileName);

            if (Directory.Exists(pathArquivo) == false)
                Directory.CreateDirectory(pathArquivo);

            if (nomeArquivo == null) 
                return nomeArquivo;

            var filePath = Path.Combine(pathArquivo, nomeArquivo);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
                arquivo.CopyToAsync(fileStream);
            
            return nomeArquivo;
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var documentacaoViewModel = await _documentacaoAppService.GetByIdAsync(id);
            return documentacaoViewModel == null ? (ActionResult) NotFound() : View(documentacaoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DocumentacaoViewModel documentacaoViewModel)
        {
            if (!ModelState.IsValid) 
                return View(documentacaoViewModel);

            await _documentacaoAppService.UpdateAsync(documentacaoViewModel);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var documentacaoViewModel = await _documentacaoAppService.GetByIdAsync(id);
            return documentacaoViewModel == null ? (IActionResult) NotFound() : View(documentacaoViewModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedAsync(Guid id)
        {
            var documento = await _documentacaoAppService.GetByIdAsync(id);
            await _documentacaoAppService.RemoveAsync(id);
            return RedirectToAction("Index", new {id = documento.ProcessoId});
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _documentacaoAppService.Dispose();
            base.Dispose(disposing);
        }
    }
}