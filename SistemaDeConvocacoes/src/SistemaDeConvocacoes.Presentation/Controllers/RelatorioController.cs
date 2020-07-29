using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Enums;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Presentation.Controllers
{
    [Authorize(Roles = "Cliente")]
    public class RelatorioController : Controller
    {
        private readonly ICargoAppService _cargoAppService;
        private readonly IConvocacaoAppService _convocacaoAppService;
        private readonly IConvocadoAppService _convocadoAppService;
        private readonly IEnumDescription _enumDescription;
        private readonly IPrimeiroAcessoAppService _primeiroAcessoAppService;

        public RelatorioController(
            ICargoAppService cargoAppService,
            IConvocadoAppService convocadoAppService,
            IConvocacaoAppService convocacaoAppService,
            IEnumDescription enumDescription,
            IPrimeiroAcessoAppService primeiroAcessoAppService)
        {
            _cargoAppService = cargoAppService;
            _convocadoAppService = convocadoAppService;
            _convocacaoAppService = convocacaoAppService;
            _enumDescription = enumDescription;
            _primeiroAcessoAppService = primeiroAcessoAppService;
        }

        public IActionResult Index(Guid Id)
        {
            ViewBag.ProcessoId = Id;
            return View();
        }

        public async Task<IActionResult> ClassificadosPorCargoAsync(Guid id)
        {
            ViewBag.ProcessoId = id;
            ViewBag.ListaCargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.Ativo.Equals(true)).Result
                .OrderBy(x => x.Nome);
            ViewBag.ListaConvocadosPorCargo = null;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ClassificadosPorCargoAsync(Guid id, Guid cargo)
        {
            ViewBag.ProcessoId = id;

            var dadosConfirmados = _convocacaoAppService.SearchAsync(a => a.ProcessoId.Equals(id)).Result
                .Where(b => b.StatusConvocacao != null);
            var convocados = await _convocadoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.CargoId.Equals(cargo));

            ViewBag.ListaConvocadosPorCargo = _convocacaoAppService.MontaListaDeConvocados(dadosConfirmados, convocados)
                .OrderBy(x => x.Posicao);
            ViewBag.ListaCargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.Ativo.Equals(true)).Result
                .OrderBy(x => x.Nome);

            return View();
        }

        public IActionResult ConvocadosQueDesistiram(Guid id)
        {
            ViewBag.ProcessoId = id;
            ViewBag.ListaCargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.Ativo.Equals(true)).Result
                .OrderBy(x => x.Nome);
            ViewBag.ListaConvocadosQueDesistiram = null;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ConvocadosQueDesistiramAsync(Guid id, Guid cargo)
        {
            ViewBag.ProcessoId = id;
            var dadosConfirmados = _convocacaoAppService.SearchAsync(a => a.ProcessoId.Equals(id)).Result.Where(b =>
                b.StatusConvocacao.Equals(_enumDescription.GetEnumDescription(StatusConvocacao.Desistente)));
            var convocados = await _convocadoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.CargoId.Equals(cargo));

            ViewBag.ListaConvocadosQueDesistiram = _convocacaoAppService
                .MontaListaDeConvocados(dadosConfirmados, convocados).OrderBy(x => x.Posicao);

            ViewBag.ListaCargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.Ativo.Equals(true)).Result
                .OrderBy(x => x.Nome);

            return View();
        }

        public IActionResult ConvocadosQueIngressaram(Guid id)
        {
            ViewBag.ProcessoId = id;
            ViewBag.ListaCargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.Ativo.Equals(true)).Result
                .OrderBy(x => x.Nome);
            ViewBag.ListaConvocadosQueIngressaram = null;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ConvocadosQueIngressaramAsync(Guid id, Guid cargo)
        {
            ViewBag.ProcessoId = id;

            var dadosConfirmados = _convocacaoAppService.SearchAsync(a => a.ProcessoId.Equals(id)).Result
                .Where(b => b.StatusConvocacao != null);
            var candidadosQueFizeramPrimeiroAcesso = await _primeiroAcessoAppService.GetAllAsync();
            var convocados = await  _convocadoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.CargoId.Equals(cargo));

            ViewBag.ListConvocadosQueIngressaram =
                _convocacaoAppService.MontaListaDeConvocados(dadosConfirmados, convocados);

            ViewBag.ListaCargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.Ativo.Equals(true)).Result
                .OrderBy(x => x.Nome);

            return View();
        }

        public IActionResult ConvocadosQueNaoIngressaram(Guid id)
        {
            ViewBag.ProcessoId = id;
            ViewBag.ListaCargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.Ativo.Equals(true)).Result
                .OrderBy(x => x.Nome);
            ViewBag.ListaConvocadosQueIngressaram = null;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ConvocadosQueNaoIngressaramAsync(Guid id, Guid cargo)
        {
            ViewBag.ProcessoId = id;
            var dadosConfirmados = await _convocacaoAppService.SearchAsync(a => a.ProcessoId.Equals(id));
            var candidadosQueFizeramPrimeiroAcesso = await _primeiroAcessoAppService.GetAllAsync();

            var naoIngressaram = new HashSet<Guid>(candidadosQueFizeramPrimeiroAcesso.Select(x => x.ConvocadoId));
            var candidatosQueNaoIngressaram = dadosConfirmados.Where(x => !naoIngressaram.Contains(x.ConvocadoId));

            var dados = candidatosQueNaoIngressaram.Select(item => dadosConfirmados.FirstOrDefault(x => x.ConvocadoId.Equals(item.ConvocadoId))).ToList();

            var dados2 = dados.Select(item => _convocadoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.CargoId.Equals(cargo) && a.ConvocadoId.Equals(item.ConvocadoId)).Result
                    .FirstOrDefault())
                .ToList();

            ViewBag.ListConvocadosQueNaoIngressaram = _convocacaoAppService.MontaListaDeConvocados(dados, dados2);
            ViewBag.ListaCargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.Ativo.Equals(true)).Result
                .OrderBy(x => x.Nome);

            return View();
        }

        public IActionResult ConvocadosPorInstituicaoEnsinoSuperior(Guid id)
        {
            ViewBag.ProcessoId = id;
            ViewBag.ListaCargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.Ativo.Equals(true)).Result
                .OrderBy(x => x.Nome);
            ViewBag.ListaConvocadosPorInstituicaoEnsinoSuperior = null;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ConvocadosPorInstituicaoEnsinoSuperiorAsync(Guid id, Guid cargo)
        {
            ViewBag.ProcessoId = id;

            var dadosConfirmados = _convocacaoAppService.SearchAsync(a => a.ProcessoId.Equals(id)).Result
                .Where(b => b.StatusConvocacao != null);
            var candidadosQueFizeramPrimeiroAcesso = _primeiroAcessoAppService.GetAllAsync();
            var convocados = await _convocadoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.CargoId.Equals(cargo));

            ViewBag.ListaConvocadosPorInstituicaoEnsinoSuperior =
                _convocacaoAppService.MontaListaDeConvocados(dadosConfirmados, convocados);
            ViewBag.ListaCargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.Ativo.Equals(true)).Result
                .OrderBy(x => x.Nome);

            return View();
        }

        public IActionResult PendentesDadosBancarios(Guid id)
        {
            ViewBag.ProcessoId = id;
            ViewBag.ListaCargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.Ativo.Equals(true)).Result
                .OrderBy(x => x.Nome);
            ViewBag.ListaConvocadosPendentesDadosBancarios = null;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PendentesDadosBancariosAsync(Guid id, Guid cargo)
        {
            ViewBag.ProcessoId = id;

            var dadosConfirmados = _convocacaoAppService.SearchAsync(a => a.ProcessoId.Equals(id)).Result
                .Where(b => b.StatusConvocacao != null);
            var candidadosQueFizeramPrimeiroAcesso = await _primeiroAcessoAppService.GetAllAsync();
            var convocados = _convocadoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.CargoId.Equals(cargo)).Result
                .Where(a => string.IsNullOrEmpty(a.Agencia) || string.IsNullOrEmpty(a.ContaCorrente) ||
                            string.IsNullOrEmpty(a.NomeAgencia));

            ViewBag.ListaConvocadosPendentesDadosBancarios =
                _convocacaoAppService.MontaListaDeConvocados(dadosConfirmados, convocados);

            ViewBag.ListaCargos = _cargoAppService.SearchAsync(a => a.ProcessoId.Equals(id) && a.Ativo.Equals(true)).Result
                .OrderBy(x => x.Nome);

            return View();
        }
    }
}