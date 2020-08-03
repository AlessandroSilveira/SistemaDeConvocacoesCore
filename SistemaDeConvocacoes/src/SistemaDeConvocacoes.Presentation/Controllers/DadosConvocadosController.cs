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
    public class DadosConvocadosController : Controller
    {
        private readonly IDadosConvocacaoAppService _dadosConvocacaoAppService;
        private readonly IProcessoAppService _processoAppService;
        private readonly IConfiguration _configuration; 

        public DadosConvocadosController(
            IDadosConvocacaoAppService dadosConvocacaoAppService, 
            IProcessoAppService processoAppService, 
            IConfiguration configuration)
        {
            _dadosConvocacaoAppService = dadosConvocacaoAppService;
            _processoAppService = processoAppService;
            _configuration = configuration;
        }

        public async Task<IActionResult> Create(Guid id)
        {
            ViewBag.id = id;
            ViewBag.ProcessoId = id;
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(id);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DadosConvocadosViewModel dadosConvocadosViewModel)
        {
            if (!ModelState.IsValid) 
                return View(dadosConvocadosViewModel);

            var pathArquivo = _configuration.GetSection("SistemaDeConvocacoesDocs").Value; /*WebConfigurationManager.AppSettings["SistemaDeConvocacoesDocs"];*/
            var arquivo = Request.Form.Files[0];

            if (arquivo == null) 
                return View(dadosConvocadosViewModel);

            var nomeArquivo = Path.GetFileName(arquivo.FileName);

            if (SalvarArquivoConvocados(out _))
                await _dadosConvocacaoAppService.SalvarCargosAsync(dadosConvocadosViewModel.Id,
                    string.Format("{0}{1}", pathArquivo, nomeArquivo));

            await _dadosConvocacaoAppService.SalvarCandidatosAsync(dadosConvocadosViewModel.Id,
                string.Format("{0}{1}", pathArquivo, nomeArquivo));

            return RedirectToAction("Index", "Processos");
        }

        private bool SalvarArquivoConvocados(out ActionResult view)
        {
            var pathArquivo = _configuration.GetSection("SistemaDeConvocacoesDocs").Value; 
            var arquivo = Request.Form.Files[0];
            if (arquivo == null)
            {
                view = null;
                return false;
            }

            var nomeArquivo = Path.GetFileName(arquivo.FileName);
            var strExtension = Path.GetExtension(arquivo.FileName)?.ToLower();

            if (VerificaArquivoExcel(out view, strExtension)) return true;

            if (!Directory.Exists(pathArquivo))
                Directory.CreateDirectory(pathArquivo);

            //arquivo.SaveAs(pathArquivo + nomeArquivo);
            return true;
        }

        private bool VerificaArquivoExcel(out ActionResult view, string strExtension)
        {
            if (!strExtension.Equals(".xls") && !strExtension.Equals(".xlsx"))
            {
                ModelState.AddModelError("Erro", "Arquivo Inválido");
                {
                    view = View();
                    return true;
                }
            }

            view = null;
            return false;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _dadosConvocacaoAppService.Dispose();

            base.Dispose(disposing);
        }
    }
}