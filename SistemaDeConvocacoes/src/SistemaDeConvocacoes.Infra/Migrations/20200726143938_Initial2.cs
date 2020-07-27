using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaDeConvocacoes.Infra.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "__MigrationHistory",
                columns: table => new
                {
                    MigrationId = table.Column<string>(maxLength: 150, nullable: false),
                    ContextKey = table.Column<string>(maxLength: 300, nullable: false),
                    Model = table.Column<byte[]>(nullable: false),
                    ProductVersion = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.__MigrationHistory", x => new { x.MigrationId, x.ContextKey });
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminId = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    Nome = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Empresa = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Cnpj = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    Telefone = table.Column<string>(unicode: false, maxLength: 11, nullable: false),
                    Imagem = table.Column<byte[]>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Senha = table.Column<string>(unicode: false, maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    Nome = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Cnpj = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Telefone = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Imagem = table.Column<string>(unicode: false, maxLength: 8000, nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    ConfirmPassword = table.Column<string>(unicode: false, maxLength: 8000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Convocacoes",
                columns: table => new
                {
                    ConvocacaoId = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    ProcessoId = table.Column<Guid>(nullable: false),
                    ConvocadoId = table.Column<Guid>(nullable: false),
                    DataEntregaDocumentos = table.Column<DateTime>(type: "datetime", nullable: false),
                    HorarioEntregaDocumento = table.Column<string>(unicode: false, maxLength: 8000, nullable: false),
                    EnderecoEntregaDocumento = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    EnviouEmail = table.Column<bool>(nullable: false),
                    Desistente = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    StatusConvocacao = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    StatusContratacao = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Convocacoes", x => x.ConvocacaoId);
                });

            migrationBuilder.CreateTable(
                name: "Convocados",
                columns: table => new
                {
                    ConvocadoId = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    ProcessoId = table.Column<Guid>(nullable: false),
                    Inscricao = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Nome = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Mae = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Sexo = table.Column<string>(unicode: false, maxLength: 8000, nullable: false),
                    Documento = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    Cpf = table.Column<string>(unicode: false, maxLength: 11, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Telefone = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Celular = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Endereco = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Numero = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Complemento = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Bairro = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Cidade = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Cep = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    Cargo = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    CargoId = table.Column<Guid>(nullable: false),
                    Pontuacao = table.Column<int>(nullable: false),
                    Posicao = table.Column<int>(nullable: false),
                    Resultado = table.Column<string>(unicode: false, maxLength: 8000, nullable: false),
                    Naturalidade = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Pai = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    EstadoCivil = table.Column<string>(unicode: false, maxLength: 8000, nullable: false),
                    DataNascimento = table.Column<string>(unicode: false, maxLength: 8000, nullable: false),
                    FatorSanguineo = table.Column<string>(unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    Doador = table.Column<string>(unicode: false, maxLength: 1, nullable: false, defaultValueSql: "('')"),
                    Recados = table.Column<string>(unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('')"),
                    Nacionalidade = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    GrauInstrucao = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    InstituicaoEnsino = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    TelefoneIES = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Curso = table.Column<string>(unicode: false, maxLength: 8000, nullable: true),
                    HorarioAulaIES = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    PeriodoAtual = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    ColacaoGrau = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    Agencia = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    NomeAgencia = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    ContaCorrente = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    Uf = table.Column<string>(unicode: false, maxLength: 2, nullable: false, defaultValueSql: "('')"),
                    OrgaoEmissor = table.Column<string>(unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Convocados", x => x.ConvocadoId);
                });

            migrationBuilder.CreateTable(
                name: "DADOS_CONTATO",
                columns: table => new
                {
                    CODIGO_PESSOA = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    E_MAIL = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    CEP = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    TIPO_DE_LOGRADOURO = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    ENDERECO = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    NUMERO = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    COMPLEMENTO = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    ESTADO = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    CIDADE = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    BAIRRO = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    ID_CONCURSO = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DADOS_CONTATO", x => x.CODIGO_PESSOA);
                });

            migrationBuilder.CreateTable(
                name: "DADOS_PESSOAIS",
                columns: table => new
                {
                    CODIGO = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    NOME = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    NACIONALIDADE = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    NATURALIDADE_UF = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    MUNICIPIO = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    DATA_DE_NASCIMENTO = table.Column<DateTime>(type: "date", nullable: false),
                    SEXO = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    ESTADO_CIVIL = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    RG = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    DATA_EXPEDICAO_RG = table.Column<DateTime>(type: "date", nullable: false),
                    ORGAO_EXPEDITOR_RG = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    UF_RG = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    NECESSIDADES_ESPECIAIS = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    DATA_E_NASCIMENTO2 = table.Column<string>(maxLength: 10, nullable: true),
                    ID_CONCURSO = table.Column<int>(nullable: true),
                    DATA_EXPEDICAO_RG2 = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DADOS_PESSOAIS", x => x.CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "DocumentoCandidato",
                columns: table => new
                {
                    DocumentoCandidatoId = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    ProcessoId = table.Column<Guid>(nullable: false),
                    ConvocadoId = table.Column<Guid>(nullable: false),
                    Documento = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    DataInclusao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Path = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Ativo = table.Column<string>(unicode: false, maxLength: 8000, nullable: false),
                    TipoDocumento = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentoCandidato", x => x.DocumentoCandidatoId);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    PessoaId = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    Nome = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Naturalidade = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Mae = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Pai = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Documento = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    OrgaoEmissor = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Sexo = table.Column<int>(nullable: true),
                    EstadoCivil = table.Column<int>(nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime", nullable: true),
                    Filhos = table.Column<int>(nullable: true),
                    Endereco = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Numero = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    Complemento = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Bairro = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Cep = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    Cidade = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Uf = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    Cargo = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    Deficiente = table.Column<bool>(nullable: true),
                    Deficiencia = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    CondicaoEspecial = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Cpf = table.Column<string>(unicode: false, maxLength: 11, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Afro = table.Column<bool>(nullable: true),
                    Telefone = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.PessoaId);
                });

            migrationBuilder.CreateTable(
                name: "PrimeiroAcesso",
                columns: table => new
                {
                    PrimeiroAcessoId = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    Email = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    ConvocadoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimeiroAcesso", x => x.PrimeiroAcessoId);
                });

            migrationBuilder.CreateTable(
                name: "TELEFONES",
                columns: table => new
                {
                    ID_TELEFONE = table.Column<int>(nullable: false),
                    CODIGO_PESSOA = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    COD_TIPO_TELEFONE = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    DDD = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    TELEFONE = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    ACEITA_SMS = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TELEFONES", x => x.ID_TELEFONE);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumento",
                columns: table => new
                {
                    TipoDocumentoId = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    TipoDocumentos = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    ProcessoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumento", x => x.TipoDocumentoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    Nome = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Login = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Senha = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Perfil = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Processos",
                columns: table => new
                {
                    ProcessoId = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    ClienteId = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    TextoDeAceitacaoDaConvocacao = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    TextoInicialTelaConvocado = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    TextoParaDesistentes = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Processos", x => x.ProcessoId);
                    table.ForeignKey(
                        name: "FK_dbo.Processos_dbo.Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    TelefoneId = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    Ddd = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    Numero = table.Column<string>(unicode: false, maxLength: 11, nullable: false),
                    PessoaId_PessoaId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.TelefoneId);
                    table.ForeignKey(
                        name: "FK_dbo.Telefone_dbo.Pessoa_PessoaId_PessoaId",
                        column: x => x.PessoaId_PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    CargoId = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
                    ProcessoId = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    CodigoCargo = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Cargos", x => x.CargoId);
                    table.ForeignKey(
                        name: "FK_dbo.Cargos_dbo.Processos_ProcessoId",
                        column: x => x.ProcessoId,
                        principalTable: "Processos",
                        principalColumn: "ProcessoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    DocumentoId = table.Column<Guid>(nullable: false),
                    ProcessoId = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Path = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Documentos", x => x.DocumentoId);
                    table.ForeignKey(
                        name: "FK_dbo.Documentos_dbo.Processos_ProcessoId",
                        column: x => x.ProcessoId,
                        principalTable: "Processos",
                        principalColumn: "ProcessoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_ProcessoId",
                table: "Cargos",
                column: "ProcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_ProcessoId",
                table: "Documentos",
                column: "ProcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Processos_ClienteId",
                table: "Processos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_PessoaId_PessoaId",
                table: "Telefone",
                column: "PessoaId_PessoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "__MigrationHistory");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Convocacoes");

            migrationBuilder.DropTable(
                name: "Convocados");

            migrationBuilder.DropTable(
                name: "DADOS_CONTATO");

            migrationBuilder.DropTable(
                name: "DADOS_PESSOAIS");

            migrationBuilder.DropTable(
                name: "DocumentoCandidato");

            migrationBuilder.DropTable(
                name: "Documentos");

            migrationBuilder.DropTable(
                name: "PrimeiroAcesso");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "TELEFONES");

            migrationBuilder.DropTable(
                name: "TipoDocumento");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Processos");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
