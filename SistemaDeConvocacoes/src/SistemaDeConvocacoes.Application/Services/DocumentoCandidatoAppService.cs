using AutoMapper;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SisConv.Application.Services
{
    public class DocumentoCandidatoAppService : IDocumentoCandidatoAppService
    {
        private readonly IDocumentoCandidatoService _documentoCandidatoService;
        private readonly IConvocadoAppService _convocadoAppService;
        private readonly IMapper _mapper;

        public string Inscricao { get; private set; }

        public DocumentoCandidatoAppService(

            IDocumentoCandidatoService documentoCandidatoService,
            IConvocadoAppService convocadoAppService
            , IMapper mapper)
        {
            _documentoCandidatoService = documentoCandidatoService;
            _convocadoAppService = convocadoAppService;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _documentoCandidatoService.Dispose();
        }

        public DocumentoCandidatoViewModel Add(DocumentoCandidatoViewModel obj)
        {
            var dados = _mapper.Map<DocumentoCandidatoViewModel, DocumentoCandidato>(obj);
            _documentoCandidatoService.Add(dados);
            return obj;
        }

        public DocumentoCandidatoViewModel GetById(Guid id)
        {
            return _mapper.Map<DocumentoCandidato, DocumentoCandidatoViewModel>(_documentoCandidatoService.GetById(id));
        }

        public IEnumerable<DocumentoCandidatoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<DocumentoCandidato>, IEnumerable<DocumentoCandidatoViewModel>>(_documentoCandidatoService.GetAll());
        }

        public DocumentoCandidatoViewModel Update(DocumentoCandidatoViewModel obj)
        {
            _documentoCandidatoService.Update(_mapper.Map<DocumentoCandidatoViewModel, DocumentoCandidato>(obj));
            return obj;
        }

        public void Remove(Guid id)
        {
            _documentoCandidatoService.Delete(id);
        }

        public IEnumerable<DocumentoCandidatoViewModel> Search(Expression<Func<DocumentoCandidato, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<DocumentoCandidato>, IEnumerable<DocumentoCandidatoViewModel>>(
                _documentoCandidatoService.Search(predicate));
        }

        public DocumentoCandidatoViewModel GetOne(Expression<Func<DocumentoCandidato, bool>> predicate)
        {
            return _mapper.Map<DocumentoCandidato, DocumentoCandidatoViewModel>(
                _documentoCandidatoService.GetOne(predicate));
        }

        public List<ListaDocumentosViewModel> MontarListaDeDocumentosDoCandidatos(IEnumerable<DocumentoCandidatoViewModel> documentos,
            IEnumerable<ConvocadoViewModel> dadosCandidatos)
        {
            var result = documentos.GroupJoin(dadosCandidatos, docs => docs.ConvocadoId, cand => cand.ConvocadoId,
                (docs, cand) => new
                {
                    docs.Ativo,
                    docs.ConvocadoId,
                    docs.DataInclusao,
                    docs.Documento,
                    docs.DocumentoCandidatoId,
                    docs.Path,
                    docs.ProcessoId,
                    docs.TipoDocumento,
                    dadosCandidatos = cand
                });

            var listaDeDocumentosCandidatos = new List<ListaDocumentosViewModel>();

            foreach (var itens in result)
            {
                listaDeDocumentosCandidatos.AddRange(itens.dadosCandidatos.Select(lista => new ListaDocumentosViewModel
                {
                    ConvocacaoId = itens.ConvocadoId,
                    Inscricao = lista.Inscricao,
                    Nome = lista.Nome,
                    Curso = lista.Cargo,
                    Path = itens.Path,
                    TipoDocumento = itens.TipoDocumento,
                    DataPostagem = itens.DataInclusao,
                    DocumentoCandidatoId = itens.DocumentoCandidatoId
                }));
            }

            return listaDeDocumentosCandidatos;
        }
    }
}