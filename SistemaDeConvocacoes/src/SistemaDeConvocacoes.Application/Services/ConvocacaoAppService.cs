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

        public ConvocacaoViewModel Add(ConvocacaoViewModel obj)
        {
            var convocacao = _mapper.Map<ConvocacaoViewModel, Convocacao>(obj);
            _convocacaoService.Add(convocacao);
            return obj;
        }

        public ConvocacaoViewModel GetById(Guid id)
        {
            return _mapper.Map<Convocacao, ConvocacaoViewModel>(_convocacaoService.GetById(id));
        }

        public IEnumerable<ConvocacaoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Convocacao>, IEnumerable<ConvocacaoViewModel>>(_convocacaoService.GetAll());
        }

        public ConvocacaoViewModel Update(ConvocacaoViewModel obj)
        {
            _convocacaoService.Update(_mapper.Map<ConvocacaoViewModel, Convocacao>(obj));
            return obj;
        }

        public void Remove(Guid id)
        {
            _convocacaoService.Remove(id);
        }

        public IEnumerable<ConvocacaoViewModel> Search(Expression<Func<Convocacao, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Convocacao>, IEnumerable<ConvocacaoViewModel>>(
                _convocacaoService.Search(predicate));
        }

        public string GerarSenhaUsuario()
        {
            return _convocacaoService.GeneratePassword();
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
                    EntrouNoSistema = _primeiroAcessoService.Search(a => a.Email.Equals(lista.Email)) == null
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

        public ConvocacaoViewModel GetOne(Expression<Func<Convocacao, bool>> predicate)
        {
            return _mapper.Map<Convocacao, ConvocacaoViewModel>(_convocacaoService.GetOne(predicate));
        }

        public IEnumerable<ConvocacaoViewModel> Search(Expression<Func<ConvocacaoViewModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }


    }
}