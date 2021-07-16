using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Application.Services
{
    public class AdminAppService : IAdminAppService
    {
       
        private readonly IAdminService _adminService;
        private readonly IMapper _mapper;
        private bool disposedValue;

        public AdminAppService(IAdminService adminService, IMapper mapper)
        {
            _adminService = adminService;
            _mapper = mapper;
        }
        public async Task<Admin2ViewModel> AddAsync(Admin2ViewModel obj)
        {
            var admin = _mapper.Map<Admin2ViewModel, Admin>(obj);            
            await _adminService.AddAsync(admin);            
            return obj;
        }

        public async Task<Admin2ViewModel> GetByIdAsync(Guid id)
        {
            return _mapper.Map<Admin, Admin2ViewModel>(await _adminService.GetByIdAsync(id));
        }

        public async Task<IEnumerable<Admin2ViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<Admin>, IEnumerable<Admin2ViewModel>>(await _adminService.GetAllAsync());
        }

        public async Task<Admin2ViewModel> UpdateAsync(Admin2ViewModel obj)
        {           
            await _adminService.UpdateAsync(_mapper.Map<Admin2ViewModel, Admin>(obj));           
            return obj;
        }

        public async Task RemoveAsync(Guid id)
        {
            await _adminService.RemoveAsync(id);            
        }

        public async Task<IEnumerable<Admin2ViewModel>> SearchAsync(Expression<Func<Admin, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Admin>, IEnumerable<Admin2ViewModel>>(await _adminService.SearchAsync(predicate));
        }

        public async Task<Admin2ViewModel> GetOneAsync(Expression<Func<Admin, bool>> predicate)
        {
            return _mapper.Map<Admin, Admin2ViewModel>(await _adminService.GetOneAsync(predicate));
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                //if (disposing)
                //{
                //     TODO: dispose managed state (managed objects)
                //}

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~AdminAppService()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}