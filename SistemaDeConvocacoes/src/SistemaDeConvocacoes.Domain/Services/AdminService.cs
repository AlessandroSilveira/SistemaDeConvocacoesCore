using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public void Dispose()
        {
            _adminRepository.Dispose();
        }

        public async Task<Admin> AddAsync(Admin obj)
        {
            return await _adminRepository.AddAsync(obj);
        }

        public async Task<Admin> GetByIdAsync(Guid id)
        {
            return await _adminRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Admin>> GetAllAsync()
        {
            return await _adminRepository.GetAllAsync();
        }

        public async Task<Admin> UpdateAsync(Admin obj)
        {
            return await _adminRepository.UpdateAsync(obj);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _adminRepository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Admin>> SearchAsync(Expression<Func<Admin, bool>> predicate)
        {
            return await _adminRepository.SearchAsync(predicate);
        }

        public async Task<Admin> GetOneAsync(Expression<Func<Admin, bool>> predicate)
        {
            return await _adminRepository.GetOneAsync(predicate);
        }
    }
}