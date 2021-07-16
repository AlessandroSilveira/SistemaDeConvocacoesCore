using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Enums;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Presentation.Controllers
{
    [Authorize(Roles = "Cliente")]
    public class ProcessosController : Controller
    {
        private readonly ICargoAppService _cargoAppService;
        private readonly IConvocacaoAppService _convocacaoAppService;
        private readonly IConvocadoAppService _convocadoAppService;
        private readonly IListaOpcoes _listaOpcoes;
        private readonly IProcessoAppService _processoAppService;
        private readonly IClienteAppService _clienteAppService;
        private readonly IHttpContextAccessor contextAccessor;
        private readonly Microsoft.Extensions.Configuration.IConfiguration _configuration;

        public ProcessosController(IProcessoAppService processoAppService,
            ICargoAppService cargoAppService,
            IConvocadoAppService convocadoAppService,
            IConvocacaoAppService convocacaoAppService,
            IListaOpcoes listaOpcoes, IClienteAppService clienteAppService, IHttpContextAccessor contextAccessor, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            _processoAppService = processoAppService;
            _cargoAppService = cargoAppService;
            _convocadoAppService = convocadoAppService;
            _convocacaoAppService = convocacaoAppService;
            _listaOpcoes = listaOpcoes;
            _clienteAppService = clienteAppService;
            this.contextAccessor = contextAccessor;
            _configuration = configuration;
        }

        public async Task<IActionResult> IndexAsync()
        {           
            var cliente = await _clienteAppService.GetOneAsync(a =>a.Email == contextAccessor.HttpContext.User.Identity.Name);
            ViewBag.Logo = cliente;
            

            return View(await _processoAppService.GetAllAsync());
        }

        public async Task<IActionResult> DetailsAsync(Guid? id)
        {
            if (id.Equals(null)) return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            var processoViewModel = await _processoAppService.GetByIdAsync(Guid.Parse(id.ToString()));
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(Guid.Parse(id.ToString()));
            ViewBag.ProcessoId = id;
            return View(processoViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(ProcessoViewModel processoViewModel)
        {
            if (!ModelState.IsValid) 
                return View(processoViewModel);

            await _processoAppService.AddAsync(processoViewModel);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EditAsync(Guid? id)
        {
            ViewBag.ProcessoId = id;

            if (id.Equals(null)) 
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            var processoViewModel = await _processoAppService.GetByIdAsync(Guid.Parse(id.ToString()));

            return View(processoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(ProcessoViewModel processoViewModel)
        {
            if (!ModelState.IsValid)
                return View(processoViewModel);

            await _processoAppService.UpdateAsync(processoViewModel);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAsync(Guid? id)
        {
            if (id.Equals(null))
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            var processoViewModel = await _processoAppService.GetByIdAsync(Guid.Parse(id.ToString()));
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(Guid.Parse(id.ToString()));
            ViewBag.ProcessoId = id;

            return View(processoViewModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedAsync(Guid id)
        {
            ViewBag.dadosProcesso = await  _processoAppService.GetByIdAsync(Guid.Parse(id.ToString()));
            ViewBag.ProcessoId = id;
            await _processoAppService.RemoveAsync(id);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EscolherCargoAsync(Guid id)
        {
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(Guid.Parse(id.ToString()));
            ViewBag.ProcessoId = id;
            ViewBag.DadosConvocacao = await _processoAppService.GetByIdAsync(id);
            ViewBag.Cargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.Ativo.Equals(true)).Result
                .OrderBy(a => a.CodigoCargo);
            ViewBag.Id = id;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ListaConvocadosAsync(string ProcessoId, string cargo)
        {
            var dadosConvocadoViewModel = new ConvocadoViewModel
            {
                CargoId = Guid.Parse(cargo),
                ProcessoId = Guid.Parse(ProcessoId)
            };

            var convocados = await _convocacaoAppService.SearchAsync(a => a.ProcessoId.Equals(dadosConvocadoViewModel.ProcessoId));

            ViewBag.DadosConvocacao = await _processoAppService.GetByIdAsync(dadosConvocadoViewModel.ProcessoId);
            var ListaCandidatos = await _convocadoAppService
                .SearchAsync(a => a.CargoId.Equals(dadosConvocadoViewModel.CargoId));
            //.OrderBy(a => a.Posicao)
            //    .Where(a => convocados.All(p2 => p2.ConvocadoId != a.ConvocadoId));

            ViewBag.ListaCandidatos = ListaCandidatos.OrderBy(a => a.Posicao).Where(a => convocados.All(p2 => p2.ConvocadoId != a.ConvocadoId));

            ViewBag.DadosCargo = await _cargoAppService.GetByIdAsync(dadosConvocadoViewModel.CargoId);
            ViewBag.ProcessoId = ProcessoId;
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(Guid.Parse(ProcessoId));

            return View();
        }

        public async Task<IActionResult> ListaConvocadosAsync(Guid ProcessoId, string cargo, bool confirmacao)
        {
            var dadosConvocadoViewModel = new ConvocadoViewModel
            {
                CargoId = Guid.Parse(cargo),
                ProcessoId = ProcessoId
            };

            ViewBag.Confirmacao = confirmacao;

            var convocados = await _convocacaoAppService.SearchAsync(a => a.ProcessoId.Equals(dadosConvocadoViewModel.ProcessoId));

            ViewBag.DadosConvocacao = await _processoAppService.GetByIdAsync(dadosConvocadoViewModel.ProcessoId);
            ViewBag.ListaCandidatos = _convocadoAppService
                .SearchAsync(a => a.CargoId.Equals(dadosConvocadoViewModel.CargoId)).Result.OrderBy(a => a.Posicao)
                .Where(a => convocados.All(p2 => p2.ConvocadoId != a.ConvocadoId));

            ViewBag.DadosCargo = await _cargoAppService.GetByIdAsync(dadosConvocadoViewModel.CargoId);
            ViewBag.ProcessoId = ProcessoId;
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(ProcessoId);
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _processoAppService.Dispose();
            base.Dispose(disposing);
        }

        public async Task<IActionResult> ConfiguracoesAsync(Guid id)
        {
            ViewBag.ProcessoId = id;
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(id);

            return View();
        }

        public async Task<IActionResult> PainelAsync(Guid id)
        {
            var totalCandidatos = await _convocadoAppService.SearchAsync(a => a.ProcessoId.Equals(id));
            var totalConvocados = await _convocacaoAppService.SearchAsync(a => a.ProcessoId.Equals(id));
            var totalDeConvocadosConfirmados =
                await _convocacaoAppService.SearchAsync(a => a.Desistente.Equals("S") && a.ProcessoId.Equals(id));
            var totalDeConvocadosDesistentes =
                await _convocacaoAppService.SearchAsync(a => a.Desistente.Equals("N") && a.ProcessoId.Equals(id));
            
            
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(id);
            ViewBag.TotalDeCandidatos = totalCandidatos.Count();
            ViewBag.TotalDeConvocados = totalConvocados.Count();
            ViewBag.TotalDeConvocadosConfirmados = totalDeConvocadosConfirmados.Count();
            ViewBag.TotalDeConvocadosDesistentes = totalDeConvocadosDesistentes.Count();
            
            return View();
        }

        public async Task<IActionResult> AtualizarCandidatosConfirmadosAsync(Guid id)
        {
            ViewBag.dadosProcesso =await  _processoAppService.GetByIdAsync(id);
            ViewBag.Cargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.Ativo.Equals(true)).Result
                .OrderBy(a => a.CodigoCargo);
            ViewBag.ListaCandidatos = null;

            var opcoesComp = _listaOpcoes.MontarListaOpcoes<StatusConvocacao>();

            ViewBag.ListaOpcoesComparecimento = opcoesComp;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarCandidatosConfirmadosAsync(Guid? id, Guid? cargo)
        {
            var novoid = Guid.Parse(id.ToString());
            var novocargo = Guid.Parse(cargo.ToString());

            if (VerificarSerCargoEstaNulo(cargo, novoid, out var actionResult)) 
                return actionResult;

            if (VerificarSeProcessoIdEstaNulo(id, novoid, out var view)) 
                return view;

            var dadosConfirmados = await _convocacaoAppService.SearchAsync(a => a.ProcessoId.Equals(novoid));
            var convocados =
                await _convocadoAppService.SearchAsync(a => a.ProcessoId.Equals(novoid) && a.CargoId.Equals(novocargo));

            ViewBag.ListaDeCandidatos = _convocacaoAppService.MontaListaDeConvocados(dadosConfirmados, convocados);
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(novoid);
            ViewBag.Cargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(novoid) && a.Ativo.Equals(true)).Result
                .OrderBy(a => a.CodigoCargo);

            var opcoesComp = _listaOpcoes.MontarListaOpcoes<StatusConvocacao>();

            ViewBag.ListaOpcoesComparecimento = opcoesComp;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarConvocacaoAsync(string opcaoConvocacao, Guid ConvocacaoId)
        {
            var dadosConvocacao = await _convocacaoAppService.GetByIdAsync(ConvocacaoId);
            dadosConvocacao.StatusConvocacao = opcaoConvocacao;
            var dados = await _convocacaoAppService.UpdateAsync(dadosConvocacao);

            return Ok(dados);
        }

        public async Task<IActionResult> AtualizarStatusEstudanteAsync(Guid id)
        {
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(id);
            ViewBag.Cargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.Ativo.Equals(true)).Result
                .OrderBy(a => a.CodigoCargo);
            ViewBag.ListaCandidatos = null;
            ViewBag.ProcessoId = id;

            var opcoesComp = _listaOpcoes.MontarListaOpcoes<StatusConvocacao>();

            ViewBag.ListaOpcoesComparecimento = opcoesComp;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarStatusEstudanteAsync(Guid? id, Guid? cargo)
        {
            var guidId = Guid.Parse(id.ToString());
            var guidCargo = Guid.Parse(cargo.ToString());

            if (VerificarSerCargoEstaNulo(cargo, guidId, out var actionResult)) 
                return actionResult;

            if (VerificarSeProcessoIdEstaNulo(id, guidId, out var view)) 
                return view;

            var dadosConfirmados = _convocacaoAppService.SearchAsync(a => a.ProcessoId.Equals(guidId)).Result
                .Where(b => b.StatusConvocacao != null);
            var convocados =
                await _convocadoAppService.SearchAsync(a => a.ProcessoId.Equals(guidId) && a.CargoId.Equals(guidCargo));
            var listaDeconvocados = _convocacaoAppService.MontaListaDeConvocados(dadosConfirmados, convocados);

            ViewBag.ListaDeCandidatos = listaDeconvocados;
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(guidId);
            ViewBag.Cargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(guidId) && a.Ativo.Equals(true)).Result
                .OrderBy(a => a.CodigoCargo);

            var opcoesContatacao = _listaOpcoes.MontarListaOpcoes<StatusConvocacao>();

            ViewBag.ProcessoId = id;
            ViewBag.ListaOpcoesContratacao = opcoesContatacao;

            return View();
        }

        private bool VerificarSeProcessoIdEstaNulo(Guid? id, Guid guidId, out ActionResult view)
        {
            if (id.Equals(null))
            {
                ModelState.AddModelError(id.ToString(), $"Algo deu errado,por favor tente novamente");
                ViewBag.Cargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(guidId) && a.Ativo.Equals(true)).Result
                    .OrderBy(a => a.CodigoCargo);
                ViewBag.dadosProcesso = _processoAppService.GetByIdAsync(guidId).Result;
                {
                    view = View();
                    return true;
                }
            }

            view = null;
            return false;
        }

        private bool VerificarSerCargoEstaNulo(Guid? cargo, Guid guidId, out ActionResult actionResult)
        {
            if (cargo.Equals(null))
            {
                ModelState.AddModelError(cargo.ToString(), $"Escolha um cargo");

                ViewBag.Cargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(guidId) && a.Ativo.Equals(true)).Result
                    .OrderBy(a => a.CodigoCargo);

                ViewBag.dadosProcesso = _processoAppService.GetByIdAsync(guidId).Result;
                {
                    actionResult = View();
                    return true;
                }
            }

            actionResult = null;
            return false;
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarStatusEstudanteParaContratacaoAsync(string opcaoStatus, Guid processoId,
            Guid convocacaoId)
        {
            var dadosConvocacao = await _convocacaoAppService.GetByIdAsync(convocacaoId);
            dadosConvocacao.StatusContratacao = opcaoStatus;

            var dados = await _convocacaoAppService.UpdateAsync(dadosConvocacao);

            return Ok(dados);
        }
    }
}