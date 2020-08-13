using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class DadosConvocadosService : IDadosConvocadosService
    {
        private readonly ICargoRepository _cargoRepository;
        private readonly IDadosConvocadosRepository _dadosConvocadosRepository;


        public DadosConvocadosService(IDadosConvocadosRepository dadosConvocadosRepository,
            ICargoRepository cargoRepository)
        {
            _dadosConvocadosRepository = dadosConvocadosRepository;
            _cargoRepository = cargoRepository;
        }

        public async Task<Convocado> AddAsync(Convocado obj)
        {
            return  await _dadosConvocadosRepository.AddAsync(obj);
        }

        public async Task<Convocado> GetByIdAsync(Guid id)
        {
            return await _dadosConvocadosRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Convocado>> GetAllAsync()
        {
            return await _dadosConvocadosRepository.GetAllAsync();
        }

        public async Task<Convocado> UpdateAsync(Convocado obj)
        {
            return await _dadosConvocadosRepository.UpdateAsync(obj);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _dadosConvocadosRepository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Convocado>> SearchAsync(Expression<Func<Convocado, bool>> predicate)
        {
            return await _dadosConvocadosRepository.SearchAsync(predicate);
        }

        public async Task SalvarCandidatosAsync(Guid id, List<Convocado> listaCandidatos)
        {
            foreach (var dados in listaCandidatos)
            {
                FormataCpf(dados);

                FormataCelular(dados);

                FormataTelefone(dados);

                var itemCargo = dados.Cargo.Split('-');

                var Codigo = itemCargo[0].Trim();

                var dadosCargo = await _cargoRepository.SearchAsync(a =>
                    a.ProcessoId.Equals(dados.ProcessoId) && a.CodigoCargo.Equals(Codigo));

                foreach (var cargo in dadosCargo)
                {
                    dados.CargoId = cargo.CargoId;
                    break;
                }

                try
                {
                    var dadosConvocado = await _dadosConvocadosRepository.SearchAsync(a =>
                        a.Nome.Equals(dados.Nome) && a.Inscricao.Equals(dados.Inscricao) && a.Cpf.Equals(dados.Cpf));

                    if (!dadosConvocado.Any())
                        await AddAsync(dados);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public async Task SalvarCargosAsync(Guid id, List<Cargo> listaCargos)
        {
            foreach (var itens in listaCargos)
            {
                var itemcargo = itens.Nome.Split('-');
                var codigo = itemcargo[0].Trim();
                var nome = itemcargo[1].Trim();

                var dadosCargo = await _cargoRepository.SearchAsync(a =>
                    a.ProcessoId.Equals(id) && a.CodigoCargo.Equals(codigo) && a.Nome.Equals(nome));

                if (!dadosCargo.Any())
                {
                    var cargo = new Cargo
                    {
                        Ativo = true,
                        CargoId = Guid.NewGuid(),
                        CodigoCargo = codigo,
                        Nome = nome,
                        ProcessoId = id
                    };
                    await _cargoRepository.AddAsync(cargo);
                }


            }
        }

        public void Dispose()
        {
            _dadosConvocadosRepository.Dispose();
        }

        public async Task<Convocado> GetOneAsync(Expression<Func<Convocado, bool>> predicate)
        {
            return await _dadosConvocadosRepository.GetOneAsync(predicate);
        }       

        private static void FormataTelefone(Convocado dados)
        {
            dados.Telefone = dados.Telefone.Replace(")", "");
            dados.Telefone = dados.Telefone.Replace("(", "");
        }

        private static void FormataCelular(Convocado dados)
        {
            dados.Celular = dados.Celular.Replace(")", "");
            dados.Celular = dados.Celular.Replace("(", "");
        }

        private static void FormataCpf(Convocado dados)
        {
            if (dados.Cpf.Length < 11)
                dados.Cpf = dados.Cpf.PadLeft(11, '0');
        }

       
    }
}
