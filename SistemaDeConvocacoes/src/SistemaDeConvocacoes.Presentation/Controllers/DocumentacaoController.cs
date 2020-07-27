using System;
using System.IO;
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

        public ActionResult Index(Guid Id)
        {
            ViewBag.ProcessoId = Id;
            ViewBag.dadosProcesso = _processoAppService.GetById(Id);
            return View(_documentacaoAppService.GetAll());
        }

        public ActionResult Details(Guid id)
        {
            var documentacaoViewModel = _documentacaoAppService.GetById(id);
            return documentacaoViewModel == null ? (ActionResult) NotFound() : View(documentacaoViewModel);
        }

        public ActionResult Create(Guid Id)
        {
            ViewBag.ProcessoId = Id;
            ViewBag.dadosProcesso = _processoAppService.GetById(Id);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DocumentacaoViewModel documentacaoViewModel)
        {
            ViewBag.dadosProcesso = _processoAppService.GetById(documentacaoViewModel.ProcessoId);
            documentacaoViewModel.DataCriacao = DateTime.Now;
            if (!ModelState.IsValid) return View(documentacaoViewModel);

            var path = SalvarArquivoConvocados(documentacaoViewModel);

            if (string.IsNullOrEmpty(path)) return RedirectToAction("Index");
            documentacaoViewModel.Path = path;
            _documentacaoAppService.Add(documentacaoViewModel);

            return RedirectToAction("Index", new {Id = documentacaoViewModel.ProcessoId});
        }

        private string SalvarArquivoConvocados(DocumentacaoViewModel documentacaoViewModel)
        {
            var pathArquivo = _configuration.GetSection("SisConvDocs").Value;
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

        public ActionResult Edit(Guid id)
        {
            var documentacaoViewModel = _documentacaoAppService.GetById(id);
            return documentacaoViewModel == null ? (ActionResult) NotFound() : View(documentacaoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DocumentacaoViewModel documentacaoViewModel)
        {
            if (!ModelState.IsValid) 
                return View(documentacaoViewModel);

            _documentacaoAppService.Update(documentacaoViewModel);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid id)
        {
            var documentacaoViewModel = _documentacaoAppService.GetById(id);
            return documentacaoViewModel == null ? (ActionResult) NotFound() : View(documentacaoViewModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            var documento = _documentacaoAppService.GetById(id);
            _documentacaoAppService.Remove(id);
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