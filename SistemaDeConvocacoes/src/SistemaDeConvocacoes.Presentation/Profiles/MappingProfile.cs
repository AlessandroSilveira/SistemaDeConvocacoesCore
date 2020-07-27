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
            CreateMap<Admin, Admin2ViewModel>();
            CreateMap<Cargo, CargoViewModel>();
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Convocacao, ConvocacoesViewModel>();
            CreateMap<Convocado, ConvocadoViewModel>();
            CreateMap<Convocado, DadosConvocadosViewModel>();
            CreateMap<Documentacao, DocumentacaoViewModel>();
            CreateMap<DocumentoCandidato, DocumentoCandidatoViewModel>();
            CreateMap<Pessoa, PessoaViewModel>();
            CreateMap<PrimeiroAcesso, PrimeiroAcessoViewModel>();
            CreateMap<Processo, ProcessoViewModel>();
            CreateMap<Telefone, TelefoneViewModel>();
            CreateMap<TipoDocumento, TipoDocumentoViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();
        }
    }
}
