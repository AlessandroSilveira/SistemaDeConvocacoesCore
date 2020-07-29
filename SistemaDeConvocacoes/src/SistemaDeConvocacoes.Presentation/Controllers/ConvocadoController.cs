using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Enums;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Presentation.Controllers
{
    public class ConvocadoController : Controller
    {
        private readonly IConvocadoAppService _convocadoAppService;
        private readonly IListaOpcoes _listaOpcoes;
        private readonly IProcessoAppService _processoAppService;

        public ConvocadoController(IConvocadoAppService convocadoAppService, IListaOpcoes listaOpcoes, IProcessoAppService processoAppService)
        {
            _convocadoAppService = convocadoAppService;
            _listaOpcoes = listaOpcoes;
            _processoAppService = processoAppService;
        }

        // GET: Convocado
        public ActionResult Index()
        {
            return View(_convocadoAppService.GetAllAsync());
        }

        // GET: Convocado/Details/5
        public ActionResult Details(Guid id)
        {
            var convocadoViewModel = _convocadoAppService.GetByIdAsync(id);
            return convocadoViewModel.Equals(null) ? (ActionResult) NotFound() : View(convocadoViewModel);
        }

        // GET: Convocado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Convocado/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(ConvocadoViewModel convocadoViewModel)
        {
            if (!ModelState.IsValid) 
                return View(convocadoViewModel);

            await _convocadoAppService.AddAsync(convocadoViewModel);

            return RedirectToAction("Index");
        }

        // GET: Convocado/Edit/5
        public async Task<IActionResult> EditAsync(Guid id, bool modal = false)
        {
            var pessoaViewModel = await _convocadoAppService.GetByIdAsync(id);

            RetornaViewBagsDasSelectList();

            ViewBag.modal = modal.ToString();
            ViewBag.dadosConvocado = await _convocadoAppService.GetByIdAsync(id);
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(pessoaViewModel.ProcessoId);

            return pessoaViewModel.Equals(null) ? (ActionResult) NotFound() : View(pessoaViewModel);
        }

        // POST: Convocado/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(ConvocadoViewModel convocadoViewModel)
        {
            if (!ModelState.IsValid)
            {
                RetornaViewBagsDasSelectList();
                return View(convocadoViewModel);
            }

            if (! await _convocadoAppService.VerificaSeHaSobrenome(convocadoViewModel.Nome))
            {
                ModelState.AddModelError("Nome", "O campo nome deve ter um sobrenome");
                RetornaViewBagsDasSelectList();
                return View(convocadoViewModel);
            }

            if (!await _convocadoAppService.VerificaSeHaSobrenome(convocadoViewModel.Mae))
            {
                ModelState.AddModelError("Mae", "O campo nome deve ter um sobrenome");
                RetornaViewBagsDasSelectList();
                return View(convocadoViewModel);
            }

            if (!await _convocadoAppService.VerificaSeHaSobrenome(convocadoViewModel.Pai))
            {
                ModelState.AddModelError("Pai", "O campo nome deve ter um sobrenome");
                RetornaViewBagsDasSelectList();
                return View(convocadoViewModel);
            }

            await _convocadoAppService.UpdateAsync(convocadoViewModel);

            return RedirectToAction("Edit", new {id = convocadoViewModel.ConvocadoId, modal = true});
        }

        private void RetornaViewBagsDasSelectList()
        {
            ViewBag.ListaSexo = _listaOpcoes.MontarListaOpcoes<Sexo>();
            ViewBag.ListaEstados = _listaOpcoes.MontarListaOpcoes<Estados>();
            ViewBag.ListaEstadoCivil = _listaOpcoes.MontarListaOpcoes<EstadoCivil>();
            ViewBag.ListaSimNao = _listaOpcoes.MontarListaOpcoes<SimNao>();
            ViewBag.ListaFatorSanguineo = _listaOpcoes.MontarListaOpcoes<FatorSanguineo>();
            ViewBag.ListaGrauInstrucao = _listaOpcoes.MontarListaOpcoes<GrauInstrucao>();
            ViewBag.ListaNacionalidade = _listaOpcoes.MontarListaOpcoes<Nacionalidade>();
        }

        // GET: Convocado/Delete/5
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var convocadoViewModel = await _convocadoAppService.GetByIdAsync(id);
            return _convocadoAppService.Equals(null) ? (ActionResult) NotFound() : View(convocadoViewModel);
        }

        // POST: Convocado/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _convocadoAppService.RemoveAsync(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) _convocadoAppService.Dispose();
            base.Dispose(disposing);
        }
    }
}