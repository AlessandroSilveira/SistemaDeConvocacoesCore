using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class CargoService : ICargoService
    {
        private readonly ICargoRepository _cargoRepository;

        public CargoService(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }

        public void Dispose()
        {
            _cargoRepository.Dispose();
        }

        public async Task<Cargo> AddAsync(Cargo obj)
        {
            return await _cargoRepository.AddAsync(obj);
        }

        public async Task<Cargo> GetByIdAsync(Guid id)
        {
            return await _cargoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Cargo>> GetAllAsync()
        {
            return await _cargoRepository.GetAllAsync();
        }

        public async Task<Cargo> UpdateAsync(Cargo obj)
        {
            return await _cargoRepository.UpdateAsync(obj);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _cargoRepository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Cargo>> SearchAsync(Expression<Func<Cargo, bool>> predicate)
        {
            return await _cargoRepository.SearchAsync(predicate);
        }

        public async Task<Cargo> GetOneAsync(Expression<Func<Cargo, bool>> predicate)
        {
            return await _cargoRepository.GetOneAsync(predicate);
        }
    }
}