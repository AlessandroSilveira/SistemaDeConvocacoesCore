using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;

namespace SistemaDeConvocacoes.Presentation.Controllers
{
    public class DocumentoCandidatoController : Controller
    {
        private readonly IDocumentoCandidatoAppService _documentoCandidatoAppService;
        private readonly ITipoDocumentoAppService _tipoDocumentoAppService;
        private readonly IConvocadoAppService _convocadoAppService;
        private readonly IProcessoAppService _processoAppService;
        private readonly IConfiguration _configuration;

        public DocumentoCandidatoController(
            IDocumentoCandidatoAppService documentoCandidatoAppService,
             ITipoDocumentoAppService tipoDocumentoAppService,
             IConvocadoAppService convocadoAppService,
             IProcessoAppService processoAppService, IConfiguration configuration)
        {
            _documentoCandidatoAppService = documentoCandidatoAppService;
            _tipoDocumentoAppService = tipoDocumentoAppService;
            _convocadoAppService = convocadoAppService;
            _processoAppService = processoAppService;
            _configuration = configuration;
        }

        // GET: DocumentoCandidato
        public ActionResult Index(Guid id, Guid ProcessoId, bool arquivoExiste = false)
        {
            ViewBag.ConvocacaoId = id;
            ViewBag.dadosConvocado = _convocadoAppService.GetByIdAsync(id);
            ViewBag.dadosProcesso = _processoAppService.GetByIdAsync(ProcessoId);
            ViewBag.ProcessoId = ProcessoId;
            ViewBag.ArquivoExiste = arquivoExiste;
            return View(_documentoCandidatoAppService.SearchAsync(a => a.ConvocadoId == id));
        }

        public async Task<IActionResult> ListaDocumentosAsync(Guid ProcessoId)
        {
            var documentos = await _documentoCandidatoAppService.SearchAsync(a => a.ProcessoId == ProcessoId);
            var dadosCandidatos = await _convocadoAppService.GetAllAsync();
            ViewBag.ProcessoId = ProcessoId;
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(ProcessoId);
            return View(_documentoCandidatoAppService.MontarListaDeDocumentosDoCandidatos(documentos, dadosCandidatos));
        }

        // GET: DocumentoCandidato/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id.Equals(null))
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            if (_documentoCandidatoAppService.GetByIdAsync(Guid.Parse(id.ToString())).Equals(null))
                return NotFound();

            return View(_documentoCandidatoAppService.GetByIdAsync(Guid.Parse(id.ToString())));
        }

        // GET: DocumentoCandidato/Create
        public async Task<IActionResult> CreateAsync(Guid id, Guid ProcessoId)
        {
            ViewBag.ConvocacaoId = id;
            ViewBag.ProcessoId = ProcessoId;
            ViewBag.dadosDocumentoCandidato = await _documentoCandidatoAppService.GetByIdAsync(id);
            ViewBag.dadosConvocado = await _convocadoAppService.GetByIdAsync(id);
            ViewBag.DadosProcesso = await _processoAppService.GetByIdAsync(ProcessoId);
            ViewBag.ListaTipoDocumento = await _tipoDocumentoAppService.SearchAsync(a => a.Ativo);

            return View();
        }

        // POST: DocumentoCandidato/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(DocumentoCandidatoViewModel documentoCandidatoViewModel)
        {
            if (!ModelState.IsValid) 
                return View(documentoCandidatoViewModel);

            var pathArquivo = _configuration.GetSection("SistemaDeConvocacoesDocs").Value;
            var arquivo = Request.Form.Files[0];
            var nomeArquivo = Path.GetFileName(arquivo.FileName);

            var file = new FileInfo(Path.Combine(pathArquivo, nomeArquivo));

            if (!file.Exists)
            {
                documentoCandidatoViewModel.DocumentoCandidatoId = Guid.NewGuid();
                documentoCandidatoViewModel.Path = SalvarDocumemento(documentoCandidatoViewModel);
                documentoCandidatoViewModel.DataInclusao = DateTime.Now;
                documentoCandidatoViewModel.Documento = nomeArquivo;
                await _documentoCandidatoAppService.AddAsync(documentoCandidatoViewModel);
                return RedirectToAction("Index", new { id = documentoCandidatoViewModel.ConvocadoId, ProcessoId = documentoCandidatoViewModel.ProcessoId });
            }
            else
            {
                return RedirectToAction("Index", new { id = documentoCandidatoViewModel.ConvocadoId, ProcessoId = documentoCandidatoViewModel.ProcessoId, @arquivoExiste = true });
            }
        }

        public string SalvarDocumemento(DocumentoCandidatoViewModel documentoCandidatoViewModel)
        {
            var pathArquivo = _configuration.GetSection("SistemaDeConvocacoesDocs").Value;            
            var arquivo = Request.Form.Files[0];
            if (arquivo == null)
                return string.Empty;

            var nomeArquivo = Path.GetFileName(arquivo.FileName);

            if (!Directory.Exists(pathArquivo))
                Directory.CreateDirectory(pathArquivo);            

            return nomeArquivo;
        }

        // GET: DocumentoCandidato/Edit/5
        public async Task<IActionResult> EditAsync(Guid? id)
        {
            if (id.Equals(null)) return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            var docCandidatoViewModel = await _documentoCandidatoAppService.GetByIdAsync(Guid.Parse(id.ToString()));
            return View(docCandidatoViewModel);
        }

        // POST: DocumentoCandidato/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(DocumentoCandidatoViewModel documentoCandidatoViewModel)
        {
            if (!ModelState.IsValid) return View(documentoCandidatoViewModel);
            await _documentoCandidatoAppService.UpdateAsync(documentoCandidatoViewModel);
            return RedirectToAction("Index", new { Id = documentoCandidatoViewModel.ProcessoId });
        }

        // GET: DocumentoCandidato/Delete/5
        public async Task<IActionResult> DeleteAsync(Guid? id, Guid ConvocadoId, Guid ProcessoId)
        {
            ViewBag.ConvocadoId = ConvocadoId;
            ViewBag.ProcessoId = ProcessoId;
            ViewBag.dadosConvocado = await _convocadoAppService.GetByIdAsync(ConvocadoId);
            ViewBag.DadosProcesso = await _processoAppService.GetByIdAsync(ProcessoId);

            if (id.Equals(null)) return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            return _documentoCandidatoAppService.GetByIdAsync(Guid.Parse(id.ToString())).Result.Equals(null)
                ? (ActionResult) NotFound()
                : View(await _documentoCandidatoAppService.GetByIdAsync(Guid.Parse(id.ToString())));
        }

        // POST: DocumentoCandidato/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedAsync(Guid id, Guid ConvocadoId, Guid ProcessoId)
        {
            ViewBag.ConvocadoId = ConvocadoId;
            ViewBag.ProcessoId = ProcessoId;
            ViewBag.dadosConvocado = await _convocadoAppService.GetByIdAsync(ConvocadoId);
            ViewBag.DadosProcesso = await _processoAppService.GetByIdAsync(ProcessoId);

            await _documentoCandidatoAppService.RemoveAsync(id);
            return RedirectToAction("Index", new { @id = ConvocadoId, @ProcessoId = ProcessoId });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _documentoCandidatoAppService.Dispose();

            base.Dispose(disposing);
        }

       
        public ActionResult Protocolo(Guid id, Guid ConvocadoId, Guid ProcessoId)
        {
            ViewBag.dadosDocumentoCandidato = _documentoCandidatoAppService.GetByIdAsync(id);
            ViewBag.dadosConvocado = _convocadoAppService.GetByIdAsync(ConvocadoId);
            ViewBag.DadosProcesso = _processoAppService.GetByIdAsync(ProcessoId);
            return View();
        }
    }
}