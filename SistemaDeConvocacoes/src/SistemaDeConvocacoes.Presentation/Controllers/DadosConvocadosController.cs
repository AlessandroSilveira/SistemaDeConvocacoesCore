using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;

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

            var listaConvocados = new List<Convocado>();
            var listaCargo = new List<Cargo>();

            try
            {
                if (dadosConvocadosViewModel.File != null && dadosConvocadosViewModel.File.Length > 0)
                {
                    // Lendo o arquivo
                    using XLWorkbook excelWorkbook = new XLWorkbook(dadosConvocadosViewModel.File.OpenReadStream(), XLEventTracking.Enabled);
                    int linha = 0;
                    try
                    {
                        var nonEmptyDataRows = excelWorkbook.Worksheet(1).RowsUsed().Skip(1);
                        foreach (var dataRow in nonEmptyDataRows)
                        {
                            linha = dataRow.RowNumber();
                            listaConvocados.Add(new Convocado()
                            {
                                //CodCotista = Convert.ToInt32(dataRow.Cell(1).Value.ToString()),
                                //AssessorDestino = Convert.ToInt32(dataRow.Cell(2).Value.ToString())

                                Inscricao = dataRow.Cell(1).Value == null ? "" : dataRow.Cell(1).Value.ToString(),
                                Nome = dataRow.Cell(2).Value == null ? "" : dataRow.Cell(2).Value.ToString(),
                                Mae = dataRow.Cell(3).Value == null ? "" : dataRow.Cell(3).Value.ToString(),
                                Sexo = dataRow.Cell(4).Value.ToString(),
                                DataNascimento = dataRow.Cell(5).Value.ToString(),
                                Documento = ApenasDigitos(dataRow.Cell(6).Value == null ? "" : dataRow.Cell(6).Value.ToString()),
                                Cpf = dataRow.Cell(7).Value == null ? "" : dataRow.Cell(7).Value.ToString(),
                                Email = dataRow.Cell(8).Value == null ? "" : dataRow.Cell(8).Value.ToString(),
                                Telefone = dataRow.Cell(9).Value == null ? "00000000000" : dataRow.Cell(9).Value.ToString(),
                                Celular = dataRow.Cell(10).Value == null ? "" : dataRow.Cell(10).Value.ToString(),
                                Endereco = dataRow.Cell(11).Value == null ? "" : dataRow.Cell(11).Value.ToString(),
                                Numero = dataRow.Cell(12).Value == null ? "" : dataRow.Cell(12).Value.ToString(),
                                Complemento = dataRow.Cell(13).Value == null ? "" : dataRow.Cell(13).Value.ToString(),
                                Bairro = dataRow.Cell(14).Value == null ? "" : dataRow.Cell(14).Value.ToString(),
                                Cidade = dataRow.Cell(15).Value == null ? "" : dataRow.Cell(15).Value.ToString(),
                                Uf = dataRow.Cell(16).Value == null ? "" : dataRow.Cell(16).Value.ToString(),
                                Cep = dataRow.Cell(17).Value == null ? "" : dataRow.Cell(17).Value.ToString(),
                                Cargo = dataRow.Cell(18).Value == null ? "" : dataRow.Cell(18).Value.ToString(),
                                CargoId = Guid.NewGuid(),
                                Pontuacao = Convert.ToInt32(dataRow.Cell(19).Value),
                                Posicao = Convert.ToInt32(dataRow.Cell(20).Value),
                                Resultado = dataRow.Cell(21).Value == null ? "" : dataRow.Cell(21).Value.ToString(),
                                ConvocadoId = Guid.NewGuid(),
                                ProcessoId = dadosConvocadosViewModel.Id,
                                Naturalidade = string.Empty,
                                EstadoCivil = string.Empty,
                                TelefoneIes = string.Empty,
                                Pai = string.Empty
                            });

                            listaCargo.Add(new Cargo
                            {
                                Nome = dataRow.Cell(18).Value == null ? "" : dataRow.Cell(18).Value.ToString()
                            });
                        }
                    }
                    catch (Exception e)
                    {
                        throw new Exception($"Ocorreu um erro na linha {linha}, erro:{e} ");
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Processos", new {@msg="Erro ao importar aquivo" });
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro:{ex} ");
            }

            await _dadosConvocacaoAppService.SalvarCargosAsync(dadosConvocadosViewModel.Id, listaCargo);

            await _dadosConvocacaoAppService.SalvarCandidatosAsync(dadosConvocadosViewModel.Id, listaConvocados);

            return RedirectToAction("Index", "Processos");
        }

        public string ApenasDigitos(string dados)
        {
            var apenasDigitos = new Regex(@"[^\d]");
            return apenasDigitos.Replace(dados, "");
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

            if (VerificaArquivoExcel(out view, strExtension))
                return true;

            if (!Directory.Exists(pathArquivo))
                Directory.CreateDirectory(pathArquivo);

            using (var fileStream = new FileStream(pathArquivo + nomeArquivo, FileMode.Create))
            {
                arquivo.CopyToAsync(fileStream);
            }
            //arquivo.CopyToAsync(pathArquivo + nomeArquivo);
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