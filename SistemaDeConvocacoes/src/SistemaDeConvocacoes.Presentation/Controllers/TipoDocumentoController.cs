using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;

namespace SistemaDeConvocacoes.Presentation.Controllers
{
    public class TipoDocumentoController : Controller
    {
        private readonly ITipoDocumentoAppService _tipoDocumentoAppService;
        private readonly IProcessoAppService _processoAppService;

        public TipoDocumentoController(
            ITipoDocumentoAppService tipoDocumentoAppService,
            IProcessoAppService processoAppService
            )
        {
            _tipoDocumentoAppService = tipoDocumentoAppService;
            _processoAppService = processoAppService;
        }

        // GET: TipoDocumento
        public async Task<IActionResult> IndexAsync(Guid Id)
        {
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(Id);
            ViewBag.ProcessoId = Id;

            return View(await _tipoDocumentoAppService.GetAllAsync());
        }

        // GET: TipoDocumento/Details/5
        public async Task<IActionResult> DetailsAsync(Guid? id)
        {
            if (id.Equals(null))
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            if (_tipoDocumentoAppService.GetByIdAsync(Guid.Parse(id.ToString())).Result.Equals(null))
                return NotFound();

            return View(await _tipoDocumentoAppService.GetByIdAsync(Guid.Parse(id.ToString())));
        }

        // GET: TipoDocumento/Create
        public async Task<IActionResult> CreateAsync(Guid Id)
        {
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(Id);
            ViewBag.ProcessoId = Id;
            return View();
        }

        // POST: TipoDocumento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(TipoDocumentoViewModel tipoDocumentoViewModel)
        {
            if (!ModelState.IsValid)
                return View(tipoDocumentoViewModel);

            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(tipoDocumentoViewModel.ProcessoId);
            ViewBag.ProcessoId = tipoDocumentoViewModel.ProcessoId;

            tipoDocumentoViewModel.TipoDocumentoId = Guid.NewGuid();
            await _tipoDocumentoAppService.AddAsync(tipoDocumentoViewModel);

             
            return RedirectToAction("Index", new { Id = tipoDocumentoViewModel.TipoDocumentoId });
        }

        // GET: TipoDocumento/Edit/5
        public async Task<IActionResult> EditAsync(Guid? id)
        {
            if (id.Equals(null))
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            var docCandidatoViewModel = await _tipoDocumentoAppService.GetByIdAsync(Guid.Parse(id.ToString()));
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(docCandidatoViewModel.ProcessoId);
            ViewBag.ProcessoId = docCandidatoViewModel.ProcessoId;

            return docCandidatoViewModel.Equals(null) ? (ActionResult) NotFound() : View(docCandidatoViewModel);
        }

        // POST: TipoDocumento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(TipoDocumentoViewModel tipoDocumentoViewModel)
        {
            if (!ModelState.IsValid)
                return View(tipoDocumentoViewModel);

            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(tipoDocumentoViewModel.ProcessoId);
            ViewBag.ProcessoId = tipoDocumentoViewModel.ProcessoId;

            await _tipoDocumentoAppService.UpdateAsync(tipoDocumentoViewModel);

            return RedirectToAction("Index", new { Id = tipoDocumentoViewModel.TipoDocumentoId });
        }

        // GET: TipoDocumento/Delete/5
        public async Task<IActionResult> DeleteAsync(Guid? id)
        {
            if (id.Equals(null))
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            var docCandidatoViewModel = await _tipoDocumentoAppService.GetByIdAsync(Guid.Parse(id.ToString()));

            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(docCandidatoViewModel.ProcessoId);
            ViewBag.ProcessoId = docCandidatoViewModel.ProcessoId;

            return _tipoDocumentoAppService.GetByIdAsync(Guid.Parse(id.ToString())).Result.Equals(null)
                ? (ActionResult) NotFound()
                : View(await _tipoDocumentoAppService.GetByIdAsync(Guid.Parse(id.ToString())));
        }

        // POST: TipoDocumento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedAsync(Guid id)
        {
            var docCandidatoViewModel = await _tipoDocumentoAppService.GetByIdAsync(Guid.Parse(id.ToString()));

            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(docCandidatoViewModel.ProcessoId);
            ViewBag.ProcessoId = docCandidatoViewModel.ProcessoId;

            await _tipoDocumentoAppService.RemoveAsync(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _tipoDocumentoAppService.Dispose();

            base.Dispose(disposing);
        }
    }
}