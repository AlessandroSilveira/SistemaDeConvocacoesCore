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
        private readonly ICargoService _cargoService;
        private readonly IMapper _mapper;

        public CargoAppService(ICargoService cargoService, IMapper mapper)
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
            var cargo = _mapper.Map<CargoViewModel, Cargo>(obj);
            _cargoService.Add(cargo);
            return obj;
        }

        public CargoViewModel GetById(Guid id)
        {
            return _mapper.Map<Cargo, CargoViewModel>(_cargoService.GetById(id));
        }

        public IEnumerable<CargoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Cargo>, IEnumerable<CargoViewModel>>(_cargoService.GetAll());
        }

        public CargoViewModel Update(CargoViewModel obj)
        {

            _cargoService.Update(_mapper.Map<CargoViewModel, Cargo>(obj));

            return obj;
        }

        public void Remove(Guid id)
        {
            _cargoService.Remove(id);
        }

        public IEnumerable<CargoViewModel> Search(Expression<Func<Cargo, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Cargo>, IEnumerable<CargoViewModel>>(_cargoService.Search(predicate));
        }

        public CargoViewModel GetOne(Expression<Func<Cargo, bool>> predicate)
        {
            return _mapper.Map<Cargo, CargoViewModel>(_cargoService.GetOne(predicate));
        }
    }
}