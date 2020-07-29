using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class TipoDocumentoService : ITipoDocumentoService
    {
        private readonly ITipoDocumentoRepository _tipoDocumentoRepository;

        public TipoDocumentoService(ITipoDocumentoRepository tipoDocumentoRepository)
        {
            _tipoDocumentoRepository = tipoDocumentoRepository;
        }
        public void Dispose()
        {
            _tipoDocumentoRepository.Dispose();
        }

        public async Task<TipoDocumento> AddAsync(TipoDocumento obj)
        {
          return await  _tipoDocumentoRepository.AddAsync(obj);
        }

        public async Task<TipoDocumento> GetByIdAsync(Guid id)
        {
            return await _tipoDocumentoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<TipoDocumento>> GetAllAsync()
        {
            return await _tipoDocumentoRepository.GetAllAsync();
        }

        public async Task<TipoDocumento> UpdateAsync(TipoDocumento obj)
        {
            return await _tipoDocumentoRepository.UpdateAsync(obj);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _tipoDocumentoRepository.RemoveAsync(id);
        }

        public Task<IEnumerable<TipoDocumento>> SearchAsync(Expression<Func<TipoDocumento, bool>> predicate)
        {
            return _tipoDocumentoRepository.SearchAsync(predicate);
        }

        public async Task<TipoDocumento> GetOneAsync(Expression<Func<TipoDocumento, bool>> predicate)
        {
            return await _tipoDocumentoRepository.GetOneAsync(predicate);
        }
    }
}