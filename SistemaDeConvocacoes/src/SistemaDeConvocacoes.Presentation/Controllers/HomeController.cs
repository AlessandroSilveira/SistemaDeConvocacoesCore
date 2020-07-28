using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Domain.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConvocacaoAppService _convocacaoAppService;
        private readonly IConvocadoAppService _convocadoAppService;
        private readonly IDocumentacaoAppService _documentacaoAppService;
        private readonly IProcessoAppService _processoAppService;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(
            IConvocadoAppService convocadoAppService,
            IProcessoAppService processoAppService,
            IConvocacaoAppService convocacaoAppService,
            IDocumentacaoAppService documentacaoAppService
, UserManager<ApplicationUser> userManager)
        {
            _convocadoAppService = convocadoAppService;
            _processoAppService = processoAppService;
            _convocacaoAppService = convocacaoAppService;
            _documentacaoAppService = documentacaoAppService;
            _userManager = userManager;
        }

        public async Task<IActionResult> IndexAsync()
        {
            if (User.IsInRole("Cliente")) 
                return RedirectToAction("Index", "Processos");

            if (!User.IsInRole("Convocado")) 
                return View();

            var user = await _userManager.FindByEmailAsync(User.Identity.Name);

            var dadosConvocado = _convocadoAppService.GetById(Guid.Parse(user.Id));
            ViewBag.dadosConvocado = dadosConvocado;

            var dadosProcesso = _processoAppService.GetById(dadosConvocado.ProcessoId);
            ViewBag.dadosProcesso = dadosProcesso;

            var dadosConvocacao = _convocacaoAppService.Search(a =>
                    a.ConvocadoId.Equals(dadosConvocado.ConvocadoId) && a.ProcessoId.Equals(dadosProcesso.ProcessoId))
                .FirstOrDefault();
            ViewBag.dadosConvocacao = dadosConvocacao;

            var listaDocumentacao = _documentacaoAppService.Search(a => a.ProcessoId.Equals(dadosProcesso.ProcessoId));
            ViewBag.ListaDocumentacao = listaDocumentacao;

            if (string.IsNullOrEmpty(dadosConvocacao.Desistente)) return View();

            if (dadosConvocacao.Desistente.Equals("N"))
                return RedirectToAction("DocumentacaoConvocado", "Convocacao",
                    new { dadosProcesso.ProcessoId, dadosConvocacao.ConvocadoId, dadosConvocacao.ConvocacaoId });

            if (dadosConvocacao.Desistente.Equals("S"))
                return RedirectToAction("DesistenciaCandidato", "Convocacao",
                    new { dadosProcesso.ProcessoId, dadosConvocacao.ConvocadoId, dadosConvocacao.ConvocacaoId });

            return View();
        }
    }
}