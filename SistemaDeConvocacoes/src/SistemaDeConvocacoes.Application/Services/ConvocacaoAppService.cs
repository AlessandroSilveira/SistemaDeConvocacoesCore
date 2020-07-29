using AutoMapper;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Enums;
using SistemaDeConvocacoes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Application.Services
{
    public class ConvocacaoAppService : IConvocacaoAppService
    {
        private readonly IConvocacaoService _convocacaoService;
        private readonly IListaOpcoes _opcoesComparecimento;
        private readonly IPrimeiroAcessoService _primeiroAcessoService;
        private readonly IMapper _mapper;

        public ConvocacaoAppService(
            IConvocacaoService convocacaoService,
            IListaOpcoes opcoesComparecimento,
            IPrimeiroAcessoService primeiroAcessoService, IMapper mapper)
        {
            _convocacaoService = convocacaoService;
            _opcoesComparecimento = opcoesComparecimento;
            _primeiroAcessoService = primeiroAcessoService;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _convocacaoService.Dispose();
        }

        public async Task<ConvocacaoViewModel> AddAsync(ConvocacaoViewModel obj)
        {
            var convocacao = _mapper.Map<ConvocacaoViewModel, Convocacao>(obj);
            await _convocacaoService.AddAsync(convocacao);
            return obj;
        }

        public async Task<ConvocacaoViewModel> GetByIdAsync(Guid id)
        {
            return _mapper.Map<Convocacao, ConvocacaoViewModel>(await _convocacaoService.GetByIdAsync(id));
        }

        public async Task<IEnumerable<ConvocacaoViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<Convocacao>, IEnumerable<ConvocacaoViewModel>>(await _convocacaoService.GetAllAsync());
        }

        public async Task<ConvocacaoViewModel> UpdateAsync(ConvocacaoViewModel obj)
        {
            await _convocacaoService.UpdateAsync(_mapper.Map<ConvocacaoViewModel, Convocacao>(obj));
            return obj;
        }

        public async Task RemoveAsync(Guid id)
        {
            await _convocacaoService.RemoveAsync(id);
        }

        public async Task<IEnumerable<ConvocacaoViewModel>> SearchAsync(Expression<Func<Convocacao, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Convocacao>, IEnumerable<ConvocacaoViewModel>>(
               await _convocacaoService.SearchAsync(predicate));
        }

        public async Task<string> GerarSenhaUsuarioAsync()
        {
            return await _convocacaoService.GeneratePasswordAsync();
        }

        public List<ConvocadoViewModel> MontaListaDeConvocados(IEnumerable<ConvocacaoViewModel> dadosConfirmados,
            IEnumerable<ConvocadoViewModel> convocados)
        {
            var result = dadosConfirmados.GroupJoin(convocados, conf => conf.ConvocadoId, conv => conv.ConvocadoId,
                (conf, conv) => new
                {
                    conf.Desistente,
                    conf.DataEntregaDocumentos,
                    conf.ConvocacaoId,
                    conf.StatusConvocacao,
                    conf.StatusContratacao,
                    conf.EntrouNoSistema,
                    convocados = conv
                });

            var listaDeconvocados = new List<ConvocadoViewModel>();

            foreach (var itens in result)
            {
                var itemDesistente = itens.Desistente;
                var itemDataEntregaDocumentos = itens.DataEntregaDocumentos;
                var convocacaoId = itens.ConvocacaoId;
                var statusConvocacao = itens.StatusConvocacao;

                listaDeconvocados.AddRange(itens.convocados.Select(lista => new ConvocadoViewModel
                {
                    ConvocacaoId = convocacaoId,
                    ConvocadoId = lista.ConvocadoId,
                    Nome = lista.Nome,
                    Posicao = lista.Posicao,
                    Inscricao = lista.Inscricao,
                    Desistente = itemDesistente,
                    EntrouNoSistema = _primeiroAcessoService.SearchAsync(a => a.Email.Equals(lista.Email)).Result == null
                        ? @"Não"
                        : "Sim",
                    DataEntregaDocumentos = itemDataEntregaDocumentos,
                    InstituicaoEnsino = lista.InstituicaoEnsino,
                    StatusConvocacao = string.IsNullOrEmpty(statusConvocacao)
                        ? ""
                        : _opcoesComparecimento.EnumDescription(
                            (StatusConvocacao)Enum.Parse(typeof(StatusConvocacao), statusConvocacao))
                }));
            }

            return listaDeconvocados;
        }

        public async Task<ConvocacaoViewModel> GetOneAsync(Expression<Func<Convocacao, bool>> predicate)
        {
            return _mapper.Map<Convocacao, ConvocacaoViewModel>(await _convocacaoService.GetOneAsync(predicate));
        }

    }
}