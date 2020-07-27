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
    public class CargoAppService : ICargoAppService
    {
        private readonly ICargosService _cargoService;
        private readonly IMapper _mapper;

        public CargoAppService(ICargosService cargoService, IMapper mapper)
        {
            _cargoService = cargoService;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _cargoService.Dispose();
        }

        public CargoViewModel Add(CargoViewModel obj)
        {
            var cargo = _mapper.Map<CargoViewModel, Cargos>(obj);
            _cargoService.Add(cargo);
            return obj;
        }

        public CargoViewModel GetById(Guid id)
        {
            return _mapper.Map<Cargos, CargoViewModel>(_cargoService.GetById(id));
        }

        public IEnumerable<CargoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Cargos>, IEnumerable<CargoViewModel>>(_cargoService.GetAll());
        }

        public CargoViewModel Update(CargoViewModel obj)
        {

            _cargoService.Update(_mapper.Map<CargoViewModel, Cargos>(obj));

            return obj;
        }

        public void Remove(Guid id)
        {
            _cargoService.Delete(id);
        }

        public IEnumerable<CargoViewModel> Search(Expression<Func<Cargos, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Cargos>, IEnumerable<CargoViewModel>>(_cargoService.Search(predicate));
        }

        public CargoViewModel GetOne(Expression<Func<Cargos, bool>> predicate)
        {
            return _mapper.Map<Cargos, CargoViewModel>(_cargoService.GetOne(predicate));
        }
    }
}