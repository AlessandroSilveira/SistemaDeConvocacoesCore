using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Models;
using SistemaDeConvocacoes.Infra.Migrations;

namespace SistemaDeConvocacoes.Infra.Context
{
    namespace ASPNetCoreIdentity.Data
    {
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            {
            }

            public virtual DbSet<Admin> Admin { get; set; }            
            public virtual DbSet<Cargo> Cargos { get; set; }
            public virtual DbSet<Cliente> Clientes { get; set; }
            public virtual DbSet<Convocacao> Convocacoes { get; set; }
            public virtual DbSet<Convocado> Convocados { get; set; }
            public virtual DbSet<DadosContato> DadosContato { get; set; }
            public virtual DbSet<DadosPessoais> DadosPessoais { get; set; }
            public virtual DbSet<DocumentoCandidato> DocumentoCandidato { get; set; }
            public virtual DbSet<Documento> Documentos { get; set; }
            public virtual DbSet<Domain.Entities.Documentacao> Documentacao { get; set; }
            public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
            public virtual DbSet<Pessoa> Pessoa { get; set; }
            public virtual DbSet<PrimeiroAcesso> PrimeiroAcesso { get; set; }
            public virtual DbSet<Processo> Processos { get; set; }
            public virtual DbSet<Telefone> Telefone { get; set; }
            public virtual DbSet<Telefone> Telefones { get; set; }
            public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
            public virtual DbSet<Usuario> Usuario { get; set; }

            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
                // Customize the ASP.NET Identity model and override the defaults if needed.
                // For example, you can rename the ASP.NET Identity table names and more.
                // Add your customizations after calling base.OnModelCreating(builder);

                builder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

                builder.Entity<Admin>(entity =>
                {
                    entity.Property(e => e.AdminId).HasDefaultValueSql("(newsequentialid())");

                    entity.Property(e => e.Cnpj)
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    entity.Property(e => e.Email)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Empresa)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.Imagem).IsRequired();

                    entity.Property(e => e.Nome)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Senha)
                        .HasMaxLength(8000)
                        .IsUnicode(false);

                    entity.Property(e => e.Telefone)
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false);
                });

               
                builder.Entity<Cargo>(entity =>
                {
                    entity.HasKey(e => e.CargoId)
                        .HasName("PK_dbo.Cargos");

                    entity.Property(e => e.CargoId).HasDefaultValueSql("(newsequentialid())");

                    entity.Property(e => e.CodigoCargo)
                        .IsRequired()
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    entity.Property(e => e.Nome)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.HasOne(d => d.Processo)
                        .WithMany(p => p.Cargos)
                        .HasForeignKey(d => d.ProcessoId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_dbo.Cargos_dbo.Processos_ProcessoId");
                });

                builder.Entity<Cliente>(entity =>
                {
                    entity.HasKey(e => e.ClienteId)
                        .HasName("PK_dbo.Clientes");

                    entity.Property(e => e.ClienteId).HasDefaultValueSql("(newsequentialid())");

                    entity.Property(e => e.Cnpj)
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    entity.Property(e => e.ConfirmPassword)
                        .HasMaxLength(8000)
                        .IsUnicode(false);

                    entity.Property(e => e.Email)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Imagem)
                        .IsRequired()
                        .HasMaxLength(8000)
                        .IsUnicode(false);

                    entity.Property(e => e.Nome)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Password)
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.Telefone)
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);
                });

                builder.Entity<Convocacao>(entity =>
                {
                    entity.HasKey(e => e.ConvocacaoId)
                        .HasName("PK_dbo.Convocacoes");

                    entity.Property(e => e.ConvocacaoId).HasDefaultValueSql("(newsequentialid())");

                    entity.Property(e => e.DataEntregaDocumentos).HasColumnType("datetime");

                    entity.Property(e => e.Desistente)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.EnderecoEntregaDocumento)
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    entity.Property(e => e.HorarioEntregaDocumento)
                        .IsRequired()
                        .HasMaxLength(8000)
                        .IsUnicode(false);

                    entity.Property(e => e.StatusContratacao)
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    entity.Property(e => e.StatusConvocacao)
                        .HasMaxLength(150)
                        .IsUnicode(false);
                });

                builder.Entity<Convocado>(entity =>
                {
                    entity.HasKey(e => e.ConvocadoId)
                        .HasName("PK_dbo.Convocados");

                    entity.Property(e => e.ConvocadoId).HasDefaultValueSql("(newsequentialid())");

                    entity.Property(e => e.Agencia)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('')");

                    entity.Property(e => e.Bairro)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Cargo)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Celular)
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.Cep)
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    entity.Property(e => e.Cidade)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.ColacaoGrau)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('')");

                    entity.Property(e => e.Complemento)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.ContaCorrente)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('')");

                    entity.Property(e => e.Cpf)
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false);

                    entity.Property(e => e.Curso)
                        .HasMaxLength(8000)
                        .IsUnicode(false);

                    entity.Property(e => e.DataNascimento)
                        .IsRequired()
                        .HasMaxLength(8000)
                        .IsUnicode(false);

                    entity.Property(e => e.Doador)
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('')");

                    entity.Property(e => e.Documento)
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    entity.Property(e => e.Email)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Endereco)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.EstadoCivil)
                        .IsRequired()
                        .HasMaxLength(8000)
                        .IsUnicode(false);

                    entity.Property(e => e.FatorSanguineo)
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('')");

                    entity.Property(e => e.GrauInstrucao)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('')");

                    entity.Property(e => e.HorarioAulaIes)
                        .IsRequired()
                        .HasColumnName("HorarioAulaIES")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('')");

                    entity.Property(e => e.Inscricao)
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.InstituicaoEnsino)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('')");

                    entity.Property(e => e.Mae)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Nacionalidade)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('')");

                    entity.Property(e => e.Naturalidade)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Nome)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.NomeAgencia)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('')");

                    entity.Property(e => e.Numero)
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.OrgaoEmissor)
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('')");

                    entity.Property(e => e.Pai)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.PeriodoAtual)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('')");

                    entity.Property(e => e.Recados)
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('')");

                    entity.Property(e => e.Resultado)
                        .IsRequired()
                        .HasMaxLength(8000)
                        .IsUnicode(false);

                    entity.Property(e => e.Sexo)
                        .IsRequired()
                        .HasMaxLength(8000)
                        .IsUnicode(false);

                    entity.Property(e => e.Telefone)
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.TelefoneIes)
                        .IsRequired()
                        .HasColumnName("TelefoneIES")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.Uf)
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('')");
                });               

                builder.Entity<DadosContato>(entity =>
                {
                    entity.HasKey(e => e.CodigoPessoa);

                    entity.ToTable("DADOS_CONTATO");

                    entity.Property(e => e.CodigoPessoa)
                        .HasColumnName("CODIGO_PESSOA")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .ValueGeneratedNever();

                    entity.Property(e => e.Bairro)
                        .IsRequired()
                        .HasColumnName("BAIRRO")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    entity.Property(e => e.Cep)
                        .IsRequired()
                        .HasColumnName("CEP")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    entity.Property(e => e.Cidade)
                        .IsRequired()
                        .HasColumnName("CIDADE")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    entity.Property(e => e.Complemento)
                        .HasColumnName("COMPLEMENTO")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    entity.Property(e => e.EMail)
                        .IsRequired()
                        .HasColumnName("E_MAIL")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    entity.Property(e => e.Endereco)
                        .IsRequired()
                        .HasColumnName("ENDERECO")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    entity.Property(e => e.Estado)
                        .IsRequired()
                        .HasColumnName("ESTADO")
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    entity.Property(e => e.IdConcurso).HasColumnName("ID_CONCURSO");

                    entity.Property(e => e.Numero)
                        .IsRequired()
                        .HasColumnName("NUMERO")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.TipoDeLogradouro)
                        .IsRequired()
                        .HasColumnName("TIPO_DE_LOGRADOURO")
                        .HasMaxLength(4)
                        .IsUnicode(false);
                });

                builder.Entity<DadosPessoais>(entity =>
                {
                    entity.HasKey(e => e.Codigo);

                    entity.ToTable("DADOS_PESSOAIS");

                    entity.Property(e => e.Codigo)
                        .HasColumnName("CODIGO")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .ValueGeneratedNever();

                    entity.Property(e => e.DataDeNascimento)
                        .HasColumnName("DATA_DE_NASCIMENTO")
                        .HasColumnType("date");

                    entity.Property(e => e.DataENascimento2)
                        .HasColumnName("DATA_E_NASCIMENTO2")
                        .HasMaxLength(10);

                    entity.Property(e => e.DataExpedicaoRg)
                        .HasColumnName("DATA_EXPEDICAO_RG")
                        .HasColumnType("date");

                    entity.Property(e => e.DataExpedicaoRg2)
                        .HasColumnName("DATA_EXPEDICAO_RG2")
                        .HasMaxLength(10);

                    entity.Property(e => e.EstadoCivil)
                        .IsRequired()
                        .HasColumnName("ESTADO_CIVIL")
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    entity.Property(e => e.IdConcurso).HasColumnName("ID_CONCURSO");

                    entity.Property(e => e.Municipio)
                        .IsRequired()
                        .HasColumnName("MUNICIPIO")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    entity.Property(e => e.Nacionalidade)
                        .IsRequired()
                        .HasColumnName("NACIONALIDADE")
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    entity.Property(e => e.NaturalidadeUf)
                        .IsRequired()
                        .HasColumnName("NATURALIDADE_UF")
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    entity.Property(e => e.NecessidadesEspeciais)
                        .IsRequired()
                        .HasColumnName("NECESSIDADES_ESPECIAIS")
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    entity.Property(e => e.Nome)
                        .IsRequired()
                        .HasColumnName("NOME")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    entity.Property(e => e.OrgaoExpeditorRg)
                        .IsRequired()
                        .HasColumnName("ORGAO_EXPEDITOR_RG")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    entity.Property(e => e.Rg)
                        .IsRequired()
                        .HasColumnName("RG")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.Sexo)
                        .IsRequired()
                        .HasColumnName("SEXO")
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    entity.Property(e => e.UfRg)
                        .IsRequired()
                        .HasColumnName("UF_RG")
                        .HasMaxLength(2)
                        .IsUnicode(false);
                });

                builder.Entity<DocumentoCandidato>(entity =>
                {
                    entity.Property(e => e.DocumentoCandidatoId).HasDefaultValueSql("(newsequentialid())");

                    entity.Property(e => e.Ativo)
                        .IsRequired()
                        .HasMaxLength(8000)
                        .IsUnicode(false);

                    entity.Property(e => e.DataInclusao).HasColumnType("datetime");

                    entity.Property(e => e.Documento)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Path)
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    entity.Property(e => e.TipoDocumento)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasDefaultValueSql("('')");
                });

                builder.Entity<Documento>(entity =>
                {
                    entity.HasKey(e => e.DocumentoId)
                        .HasName("PK_dbo.Documentos");

                    entity.Property(e => e.DocumentoId).ValueGeneratedNever();

                    entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                    entity.Property(e => e.Descricao)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Path)
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    entity.HasOne(d => d.Processo)
                        .WithMany(p => p.Documentos)
                        .HasForeignKey(d => d.ProcessoId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_dbo.Documentos_dbo.Processos_ProcessoId");
                }
                );


                builder.Entity<Domain.Entities.Documentacao>(entity =>
                {
                    entity.HasKey(e => e.DocumentoId)
                       .HasName("PK_dbo.Documentacao");

                    entity.Property(e => e.DocumentoId).ValueGeneratedNever();

                    entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                    entity.Property(e => e.Descricao)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Path)
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    entity.HasOne(d => d.Convocacao)
                        .WithMany(p => p.Documentacoes)
                        .HasForeignKey(d => d.ConvocacaoId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_dbo.Documentos_dbo.Convocacao_ConvocacaoId");
                });

                builder.Entity<MigrationHistory>(entity =>
                {
                    entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                        .HasName("PK_dbo.__MigrationHistory");

                    entity.ToTable("__MigrationHistory");

                    entity.Property(e => e.MigrationId).HasMaxLength(150);

                    entity.Property(e => e.ContextKey).HasMaxLength(300);

                    entity.Property(e => e.Model).IsRequired();

                    entity.Property(e => e.ProductVersion)
                        .IsRequired()
                        .HasMaxLength(32);
                });

                builder.Entity<Pessoa>(entity =>
                {
                    entity.Property(e => e.PessoaId).HasDefaultValueSql("(newsequentialid())");

                    entity.Property(e => e.Bairro)
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Cargo)
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    entity.Property(e => e.Cep)
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    entity.Property(e => e.Cidade)
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Complemento)
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.CondicaoEspecial)
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Cpf)
                        .HasMaxLength(11)
                        .IsUnicode(false);

                    entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                    entity.Property(e => e.DataNascimento).HasColumnType("datetime");

                    entity.Property(e => e.Deficiencia)
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Documento)
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    entity.Property(e => e.Email)
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Endereco)
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Mae)
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Naturalidade)
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Nome)
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Numero)
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    entity.Property(e => e.OrgaoEmissor)
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    entity.Property(e => e.Pai)
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Telefone)
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.Uf)
                        .HasMaxLength(2)
                        .IsUnicode(false);
                });

                builder.Entity<PrimeiroAcesso>(entity =>
                {
                    entity.Property(e => e.PrimeiroAcessoId).HasDefaultValueSql("(newsequentialid())");

                    entity.Property(e => e.Data).HasColumnType("datetime");

                    entity.Property(e => e.Email)
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false);
                });

                builder.Entity<Processo>(entity =>
                {
                    entity.HasKey(e => e.ProcessoId)
                        .HasName("PK_dbo.Processos");

                    entity.Property(e => e.ProcessoId).HasDefaultValueSql("(newsequentialid())");

                    entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                    entity.Property(e => e.Nome)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.TextoDeAceitacaoDaConvocacao)
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    entity.Property(e => e.TextoInicialTelaConvocado)
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    entity.Property(e => e.TextoParaDesistentes)
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    entity.HasOne(d => d.Cliente)
                        .WithMany(p => p.Processos)
                        .HasForeignKey(d => d.ClienteId)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_dbo.Processos_dbo.Clientes_ClienteId");
                });

                builder.Entity<Telefone>(entity =>
                {
                    entity.HasKey(c => c.IdTelefone);

                    entity.Property(c => c.IdTelefone)
                        .HasColumnName("IdTelefone");

                    entity.Property(c => c.Ddd)
                        .IsRequired()
                        .HasMaxLength(2);

                    entity.Property(c => c.Numero)
                        .IsRequired()
                        .HasMaxLength(11);

                    entity.ToTable("Telefone");
                });

                builder.Entity<TipoDocumento>(entity =>
                {
                    entity.Property(e => e.TipoDocumentoId).HasDefaultValueSql("(newsequentialid())");

                    entity.Property(e => e.TipoDocumentos)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);
                });

                builder.Entity<Usuario>(entity =>
                {
                    entity.Property(e => e.UsuarioId).HasDefaultValueSql("(newsequentialid())");

                    entity.Property(e => e.Email)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Login)
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    entity.Property(e => e.Nome)
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    entity.Property(e => e.Perfil)
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.Senha)
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false);
                });

            }
        }
    }
}
