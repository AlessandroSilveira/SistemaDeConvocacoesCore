using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Enums;
using SistemaDeConvocacoes.Domain.Interfaces.Helper;
using SistemaDeConvocacoes.Domain.Interfaces.Services;
using SistemaDeConvocacoes.Domain.Models;
using SistemaDeConvocacoes.Presentation.Models;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace SistemaDeConvocacoes.Presentation.Controllers
{
    [Authorize(Roles = "Cliente, Convocado")]
    public class ConvocacaoController : Controller
    {
        private readonly IConvocacaoAppService _convocacaoAppService;
        private readonly IConvocacaoService _convocacaoService;
        private readonly IConvocadoAppService _convocadoAppService;
        private readonly IDocumentacaoAppService _documentacaoAppService;
        private readonly IEnumDescription _enumDescription;
        private readonly IPasswordGeneratorService _passwordGenerator;
        private readonly IProcessoAppService _processoAppService;
        private readonly ISysConfig _sysConfig;
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public ConvocacaoController(IConvocacaoAppService convocacaoAppService,
            IConvocadoAppService convocadoAppService, Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager,
            IDocumentacaoAppService documentacaoAppService,
            IProcessoAppService processoAppService,
            IEnumDescription enumDescription,
            ISysConfig sysConfig,
            IConvocacaoService convocacaoService,
            IPasswordGeneratorService passwordGenerator, IConfiguration configuration)
        {
            _convocacaoAppService = convocacaoAppService;
            _convocadoAppService = convocadoAppService;
            _userManager = userManager;
            _documentacaoAppService = documentacaoAppService;
            _processoAppService = processoAppService;
            _enumDescription = enumDescription;
            _sysConfig = sysConfig;
            _convocacaoService = convocacaoService;
            _passwordGenerator = passwordGenerator;
            _configuration = configuration;
        }

        public ActionResult Index()
        {
            return View(_convocacaoAppService.GetAllAsync());
        }

        public ActionResult Details(Guid? id)
        {
            if (id.Equals(null)) return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            var convocacaoViewModel = _convocacaoAppService.GetByIdAsync(Guid.Parse(id.ToString()));
            return convocacaoViewModel.Equals(null) ? (ActionResult) NotFound() : View(convocacaoViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(ConvocacaoViewModel convocacaoViewModel, string cargo)
        {
            if (!ModelState.IsValid) return View(convocacaoViewModel);

            var selecionado = convocacaoViewModel.CandidatosSelecionados.Split(',');
            var confirmacao = false;

            convocacaoViewModel.StatusConvocacao = StatusConvocacao.EmConvocacao.ToString();

            foreach (var t in selecionado)
            {
                var dadosConvocado = await _convocadoAppService.GetByIdAsync(Guid.Parse(t));
                RegistarCandidatoParaFazerLogin(dadosConvocado);
                convocacaoViewModel.ConvocadoId = Guid.Parse(t);
                var gravaConvocacao = await _convocacaoAppService.AddAsync(convocacaoViewModel);

                if (gravaConvocacao == null)
                    break;

                confirmacao = true;

                //EnviarEmailAsync(dadosConvocado);
            }

            return RedirectToAction("ListaConvocados", "Processos",
                new {ProcessoId = convocacaoViewModel.ProcessoId.ToString(), cargo = cargo, confirmacao});
        }

        //private void EnviarEmailAsync(ConvocadoViewModel dadosConvocado)
        //{
        //    var user = _userManager.FindByNameAsync(dadosConvocado.Email);
        //    _userManager.ema /*SendEmailAsync(user.Id, ObterAssuntoEmail(dadosConvocado), ObterBodyParaEnvioEmail(dadosConvocado));*/
        //}

        private async Task<string> ObterAssuntoEmail(ConvocadoViewModel convocacao)
        {
            var dadosProcesso = await _processoAppService.GetByIdAsync(convocacao.ProcessoId);
            return string.Format("Prezado candidato {0} você está convocado para o {1}", convocacao.Nome,
                dadosProcesso.Nome);
        }

        public string ObterBodyParaEnvioEmail(ConvocadoViewModel convocacao)
        {
            //var context = new ApplicationDbContext();
            //var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            //var dadosCandidato = userManager.FindByEmailAsync(convocacao.Email);

            //var dadosConvocacao = _convocacaoService.GetOne(a =>
            //    a.ProcessoId.Equals(convocacao.ProcessoId) && a.ConvocadoId.Equals(convocacao.ConvocadoId));
            //var dadosProcesso = _processoAppService.GetById(convocacao.ProcessoId);

            //var contentEmail = _sysConfig.GetHelpFile("EmailDeConvocacao");
            //var body = GetTagContent(contentEmail, "body");
            //if (body == string.Empty)
            //    return string.Empty;

            //var senhaCandidato = _passwordGenerator.GetPassword();

            //userManager.RemovePasswordAsync(dadosCandidato);
            //userManager.AddPasswordAsync(dadosCandidato, senhaCandidato);

            //body = body.Replace("{DATA}", dadosConvocacao.DataEntregaDocumentos.ToString());
            //body = body.Replace("{HORA}", dadosConvocacao.HorarioEntregaDocumento);
            //body = body.Replace("{ENDERECO}", dadosConvocacao.EnderecoEntregaDocumento);
            //body = body.Replace("{NOMECONVOCACAO}", dadosProcesso.Nome);
            //body = body.Replace("{USUARIO}", convocacao.Nome);
            //body = body.Replace("{SENHA}", senhaCandidato);

            return string.Empty;
        }

        private static string GetTagContent(string fullcontent, string tag)
        {
            var tagStart = "<" + tag.ToUpper() + ">";
            var tagEnd = "</" + tag.ToUpper() + ">";
            var posStart = fullcontent.ToUpper().IndexOf(tagStart);
            var posEnd = fullcontent.ToUpper().IndexOf(tagEnd);

            if (posStart >= 0) posStart += tagStart.Length;

            return posStart >= 0 && posEnd > posStart ? fullcontent.Substring(posStart, posEnd - posStart) : "";
        }

        private async Task<string> GerarSenha()
        {
            return await _convocacaoAppService.GerarSenhaUsuarioAsync();
        }

        public ActionResult Edit(Guid? id)
        {
            if (id.Equals(null)) return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            var convocacaoViewModel = _convocacaoAppService.GetByIdAsync(Guid.Parse(id.ToString()));
            return convocacaoViewModel.Equals(null) ? (ActionResult) NotFound() : View(convocacaoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ConvocacaoViewModel convocacaoViewModel)
        {
            if (!ModelState.IsValid) return View(convocacaoViewModel);
            _convocacaoAppService.UpdateAsync(convocacaoViewModel);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid? id)
        {
            if (id.Equals(null)) return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            var convocacaoViewModel = _convocacaoAppService.GetByIdAsync(Guid.Parse(id.ToString()));
            return convocacaoViewModel.Equals(null) ? (ActionResult) NotFound() : View(convocacaoViewModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _convocacaoAppService.RemoveAsync(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _convocacaoAppService.Dispose();

            base.Dispose(disposing);
        }

        private async void RegistarCandidatoParaFazerLogin(ConvocadoViewModel convocadoViewModel)
        {
            if (ObterDadosConvocado(convocadoViewModel, out var dadosConvocado)) return;

            var user = new ApplicationUser
            {
                Id = dadosConvocado.ConvocadoId.ToString(),
                UserName = convocadoViewModel.Email,
                Email = convocadoViewModel.Email
            };

            var dados = _userManager.FindByEmailAsync(user.Email);
            if (dados != null) return;
            await _userManager.CreateAsync(user, await GerarSenha());
            var user2 = await _userManager.FindByNameAsync(dadosConvocado.Email);
            await _userManager.AddToRoleAsync(user2, RolesNames.ROLE_CONVOCADO);
        }

        private bool ObterDadosConvocado(ConvocadoViewModel convocadoViewModel, out ConvocadoViewModel dadosConvocado)
        {
            dadosConvocado = _convocadoAppService.SearchAsync(a => a.ConvocadoId.Equals(convocadoViewModel.ConvocadoId)).Result
                .FirstOrDefault();
            return dadosConvocado == null;
        }

        [HttpPost]
        public ActionResult ConfirmaConvocacao(Guid processoId, Guid convocadoId, Guid convocacaoId, string decisao)
        {
            var dadosConvocacao =
                _convocacaoAppService.GetByIdAsync(convocacaoId).Result;

            dadosConvocacao.Desistente = decisao;

            dadosConvocacao.StatusConvocacao = decisao.Equals("S") ? StatusConvocacao.Desistente.ToString() : StatusConvocacao.EmConvocacao.ToString();

            _convocacaoAppService.UpdateAsync(dadosConvocacao);
            return RedirectToAction(decisao.Equals("S") ? "DesistenciaCandidato" : "DocumentacaoConvocado",
                "Convocacao", new {ProcessoId = processoId, ConvocadoId = convocadoId, ConvocacaoId = convocacaoId});
        }

        public async Task<ActionResult> DocumentacaoConvocado(Guid processoId, Guid convocadoId, Guid convocacaoId)
        {
            ViewBag.dadosProcesso = await  _processoAppService.GetByIdAsync(processoId);
            var dadosConvocado = _convocadoAppService.GetByIdAsync(Guid.Parse(IdentityExtensions.GetUserId(User.Identity)));
            ViewBag.dadosConvocado = dadosConvocado;
            ViewBag.listaDocumentacao = await _documentacaoAppService.SearchAsync(a => a.ProcessoId.Equals(processoId));
            return View();
        }

        public void Download(string arquivo)
        {
            //var pathArquivo = _configuration.GetSection("SisConvDocs").Value;  /*WebConfigurationManager.AppSettings[@"SisConvDocs"];*/
            //var caminhoArquivo = Path.Combine(pathArquivo, arquivo);
            //var fInfo = new FileInfo(caminhoArquivo);
            //HttpContext.Response.Clear();
            //HttpContext.Response.ContentType = "application/octet-stream";
            //HttpContext.Response.AddHeader("Content-Disposition", "attachment; filename=\"" + fInfo.Name + "\"");
            //HttpContext.Response.AddHeader("Content-Length", fInfo.Length.ToString());
            //HttpContext.Response.Flush();
            //HttpContext.Response.WriteFile(fInfo.FullName);
            //fInfo = null;
        }

        public ActionResult DesistenciaCandidato(Guid processoId, Guid convocadoId, Guid convocacaoId)
        {
            ViewBag.dadosConvocacao = _convocacaoAppService.GetByIdAsync(convocacaoId);
            var dadosConvocado = _convocadoAppService.GetByIdAsync(convocadoId);
            ViewBag.dadosConvocado = dadosConvocado;
            ViewBag.dadosProcesso = _processoAppService.GetByIdAsync(processoId);
            return View();
        }
    }
}