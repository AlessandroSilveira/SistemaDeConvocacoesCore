using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Application.Services
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

        public async Task<DocumentoCandidatoViewModel> AddAsync(DocumentoCandidatoViewModel obj)
        {
            var dados = _mapper.Map<DocumentoCandidatoViewModel, DocumentoCandidato>(obj);
            await _documentoCandidatoService.AddAsync(dados);
            return obj;
        }

        public async Task<DocumentoCandidatoViewModel> GetByIdAsync(Guid id)
        {
            return _mapper.Map<DocumentoCandidato, DocumentoCandidatoViewModel>(await _documentoCandidatoService.GetByIdAsync(id));
        }

        public async Task<IEnumerable<DocumentoCandidatoViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<DocumentoCandidato>, IEnumerable<DocumentoCandidatoViewModel>>(await _documentoCandidatoService.GetAllAsync());
        }

        public async Task<DocumentoCandidatoViewModel> UpdateAsync(DocumentoCandidatoViewModel obj)
        {
            await _documentoCandidatoService.UpdateAsync(_mapper.Map<DocumentoCandidatoViewModel, DocumentoCandidato>(obj));
            return obj;
        }

        public async Task RemoveAsync(Guid id)
        {
            await _documentoCandidatoService.RemoveAsync(id);
        }

        public async Task<IEnumerable<DocumentoCandidatoViewModel>> SearchAsync(Expression<Func<DocumentoCandidato, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<DocumentoCandidato>, IEnumerable<DocumentoCandidatoViewModel>>(
                await _documentoCandidatoService.SearchAsync(predicate));
        }

        public async Task<DocumentoCandidatoViewModel> GetOneAsync(Expression<Func<DocumentoCandidato, bool>> predicate)
        {
            return _mapper.Map<DocumentoCandidato, DocumentoCandidatoViewModel>(
               await _documentoCandidatoService.GetOneAsync(predicate));
        }

        public async Task<List<ListaDocumentosViewModel>> MontarListaDeDocumentosDoCandidatos(IEnumerable<DocumentoCandidatoViewModel> documentos,
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