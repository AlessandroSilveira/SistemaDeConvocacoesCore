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
    public class CargoAppService : ICargoAppService
    {
        private readonly ICargoService _cargoService;
        private readonly IMapper _mapper;
        private bool disposedValue;

        public CargoAppService(ICargoService cargoService, IMapper mapper)
        {
            _cargoService = cargoService;
            _mapper = mapper;
        }


       
        public async Task<CargoViewModel> AddAsync(CargoViewModel obj)
        {
            var cargo = _mapper.Map<CargoViewModel, Cargo>(obj);
            await _cargoService.AddAsync(cargo);
            return obj;
        }

        public async Task<CargoViewModel> GetByIdAsync(Guid id)
        {
            return _mapper.Map<Cargo, CargoViewModel>(await _cargoService.GetByIdAsync(id));
        }

        public async Task<IEnumerable<CargoViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<Cargo>, IEnumerable<CargoViewModel>>(await _cargoService.GetAllAsync());
        }

        public async Task<CargoViewModel> UpdateAsync(CargoViewModel obj)
        {
            await _cargoService.UpdateAsync(_mapper.Map<CargoViewModel, Cargo>(obj));

            return obj;
        }

        public async Task RemoveAsync(Guid id)
        {
            await _cargoService.RemoveAsync(id);
        }

        public async Task<IEnumerable<CargoViewModel>> SearchAsync(Expression<Func<Cargo, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Cargo>, IEnumerable<CargoViewModel>>(await _cargoService.SearchAsync(predicate));
        }

        public async Task<CargoViewModel> GetOneAsync(Expression<Func<Cargo, bool>> predicate)
        {
            return _mapper.Map<Cargo, CargoViewModel>(await _cargoService.GetOneAsync(predicate));
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~CargoAppService()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}