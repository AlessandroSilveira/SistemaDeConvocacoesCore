using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Presentation.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Admin2ViewModel, Admin>();
            CreateMap<CargoViewModel,Cargo> ();
            CreateMap<IEnumerable<CargoViewModel>,IEnumerable<Cargo>>();
            CreateMap<Cargo, CargoViewModel>();
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<IEnumerable<ClienteViewModel>, IEnumerable<Cliente>>();
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<ConvocacoesViewModel,Convocacao >();
            CreateMap<ConvocadoViewModel,Convocado>();
            CreateMap<DadosConvocadosViewModel,Convocado>();            
            CreateMap<DocumentacaoViewModel, Documentacao>();
            CreateMap<Documentacao, DocumentacaoViewModel>();
            CreateMap< IEnumerable<DocumentoCandidatoViewModel>, IEnumerable<DocumentoCandidato>>();
            CreateMap<PessoaViewModel,Pessoa>();
            CreateMap<PrimeiroAcessoViewModel,PrimeiroAcesso >();
            CreateMap<ProcessoViewModel,Processo>();
            CreateMap<Processo, ProcessoViewModel>();
            CreateMap< IEnumerable<ProcessoViewModel>,IEnumerable<Processo>>();

            CreateMap<TelefoneViewModel,Telefone>();
            CreateMap<TipoDocumentoViewModel,TipoDocumento>();
            CreateMap<UsuarioViewModel, Usuario>();
        }
    }
}
