using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

        public AdminAppService(IAdminService adminService, IMapper mapper)
        {
            _adminService = adminService;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _adminService.Dispose();
        }

        public Admin2ViewModel Add(Admin2ViewModel obj)
        {
            var admin = _mapper.Map<Admin2ViewModel, Admin>(obj);            
            _adminService.Add(admin);            
            return obj;
        }

        public Admin2ViewModel GetById(Guid id)
        {
            return _mapper.Map<Admin, Admin2ViewModel>(_adminService.GetById(id));
        }

        public IEnumerable<Admin2ViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Admin>, IEnumerable<Admin2ViewModel>>(_adminService.GetAll());
        }

        public Admin2ViewModel Update(Admin2ViewModel obj)
        {           
            _adminService.Update(_mapper.Map<Admin2ViewModel, Admin>(obj));           
            return obj;
        }

        public void Remove(Guid id)
        {           
            _adminService.Remove(id);            
        }

        public IEnumerable<Admin2ViewModel> Search(Expression<Func<Admin, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Admin>, IEnumerable<Admin2ViewModel>>(_adminService.Search(predicate));
        }

        public Admin2ViewModel GetOne(Expression<Func<Admin, bool>> predicate)
        {
            return _mapper.Map<Admin, Admin2ViewModel>(_adminService.GetOne(predicate));
        }
    }
}