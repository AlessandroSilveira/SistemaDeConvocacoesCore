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

        public async Task<IActionResult> Index()
        {
            if (User.IsInRole("Cliente")) 
                return RedirectToAction("Index", "Processos");

            //if (!User.IsInRole("CONVOCADO")) 
            //    return View();

            var user = await _userManager.FindByEmailAsync(User.Identity.Name);

            var dadosConvocado = await _convocadoAppService.GetByIdAsync(Guid.Parse(user.Id));
            ViewBag.dadosConvocado = dadosConvocado;

            var dadosProcesso = await _processoAppService.GetByIdAsync(dadosConvocado.ProcessoId);
            ViewBag.dadosProcesso = dadosProcesso;

            var dadosConvocacao = await _convocacaoAppService.SearchAsync(a =>
                    a.ConvocadoId.Equals(dadosConvocado.ConvocadoId) && a.ProcessoId.Equals(dadosProcesso.ProcessoId));
                     

            ViewBag.dadosConvocacao = dadosConvocacao.FirstOrDefault(); 

            var listaDocumentacao = await _documentacaoAppService.SearchAsync(a => a.ProcessoId.Equals(dadosProcesso.ProcessoId));
            ViewBag.ListaDocumentacao = listaDocumentacao;

            if (dadosConvocacao == null || string.IsNullOrEmpty(dadosConvocacao.FirstOrDefault().Desistente))
                return View();

            if (dadosConvocacao.FirstOrDefault().Desistente.Equals("N"))
                return RedirectToAction("DocumentacaoConvocado", "Convocacao",
                    new { dadosProcesso.ProcessoId, dadosConvocacao.FirstOrDefault().ConvocadoId, dadosConvocacao.FirstOrDefault().ConvocacaoId });

            if (dadosConvocacao.FirstOrDefault().Desistente.Equals("S"))
                return RedirectToAction("DesistenciaCandidato", "Convocacao",
                    new { dadosProcesso.ProcessoId, dadosConvocacao.FirstOrDefault().ConvocadoId, dadosConvocacao.FirstOrDefault().ConvocacaoId });

            return View();
        }
    }
}