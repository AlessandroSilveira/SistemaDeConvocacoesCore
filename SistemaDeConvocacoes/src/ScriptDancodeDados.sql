USE [master]
GO
/****** Object:  Database [SisConvCore]    Script Date: 13/08/2020 18:16:39 ******/
CREATE DATABASE [SisConvCore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SisConvCore', FILENAME = N'/var/opt/mssql/data/SisConvCore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SisConvCore_log', FILENAME = N'/var/opt/mssql/data/SisConvCore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SisConvCore] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SisConvCore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SisConvCore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SisConvCore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SisConvCore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SisConvCore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SisConvCore] SET ARITHABORT OFF 
GO
ALTER DATABASE [SisConvCore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SisConvCore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SisConvCore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SisConvCore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SisConvCore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SisConvCore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SisConvCore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SisConvCore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SisConvCore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SisConvCore] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SisConvCore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SisConvCore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SisConvCore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SisConvCore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SisConvCore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SisConvCore] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [SisConvCore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SisConvCore] SET RECOVERY FULL 
GO
ALTER DATABASE [SisConvCore] SET  MULTI_USER 
GO
ALTER DATABASE [SisConvCore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SisConvCore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SisConvCore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SisConvCore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SisConvCore] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SisConvCore', N'ON'
GO
ALTER DATABASE [SisConvCore] SET QUERY_STORE = OFF
GO
USE [SisConvCore]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminId] [uniqueidentifier] NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Empresa] [varchar](50) NOT NULL,
	[Cnpj] [varchar](15) NOT NULL,
	[Telefone] [varchar](11) NOT NULL,
	[Imagem] [varbinary](max) NOT NULL,
	[Ativo] [bit] NOT NULL,
	[Senha] [varchar](8000) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cargos]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargos](
	[CargoId] [uniqueidentifier] NOT NULL,
	[ProcessoId] [uniqueidentifier] NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[CodigoCargo] [varchar](4) NOT NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Cargos] PRIMARY KEY CLUSTERED 
(
	[CargoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ClienteId] [uniqueidentifier] NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Cnpj] [varchar](15) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Telefone] [varchar](20) NOT NULL,
	[Imagem] [varchar](8000) NOT NULL,
	[Ativo] [bit] NOT NULL,
	[Password] [varchar](10) NOT NULL,
	[ConfirmPassword] [varchar](8000) NULL,
 CONSTRAINT [PK_dbo.Clientes] PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Convocacoes]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Convocacoes](
	[ConvocacaoId] [uniqueidentifier] NOT NULL,
	[ProcessoId] [uniqueidentifier] NOT NULL,
	[ConvocadoId] [uniqueidentifier] NOT NULL,
	[DataEntregaDocumentos] [datetime] NOT NULL,
	[HorarioEntregaDocumento] [varchar](8000) NOT NULL,
	[EnderecoEntregaDocumento] [varchar](150) NOT NULL,
	[EnviouEmail] [bit] NOT NULL,
	[Desistente] [varchar](1) NULL,
	[Ativo] [bit] NOT NULL,
	[StatusConvocacao] [varchar](150) NULL,
	[StatusContratacao] [varchar](150) NULL,
 CONSTRAINT [PK_dbo.Convocacoes] PRIMARY KEY CLUSTERED 
(
	[ConvocacaoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Convocados]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Convocados](
	[ConvocadoId] [uniqueidentifier] NOT NULL,
	[ProcessoId] [uniqueidentifier] NOT NULL,
	[Inscricao] [varchar](10) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Mae] [varchar](100) NOT NULL,
	[Sexo] [varchar](8000) NOT NULL,
	[Documento] [varchar](25) NOT NULL,
	[Cpf] [varchar](11) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Telefone] [varchar](20) NOT NULL,
	[Celular] [varchar](20) NOT NULL,
	[Endereco] [varchar](100) NOT NULL,
	[Numero] [varchar](50) NOT NULL,
	[Complemento] [varchar](100) NOT NULL,
	[Bairro] [varchar](100) NOT NULL,
	[Cidade] [varchar](50) NOT NULL,
	[Cep] [varchar](8) NOT NULL,
	[Cargo] [varchar](100) NOT NULL,
	[CargoId] [uniqueidentifier] NOT NULL,
	[Pontuacao] [int] NOT NULL,
	[Posicao] [int] NOT NULL,
	[Resultado] [varchar](8000) NOT NULL,
	[Naturalidade] [varchar](100) NOT NULL,
	[Pai] [varchar](100) NOT NULL,
	[EstadoCivil] [varchar](8000) NOT NULL,
	[DataNascimento] [varchar](8000) NOT NULL,
	[FatorSanguineo] [varchar](2) NOT NULL,
	[Doador] [varchar](1) NOT NULL,
	[Recados] [varchar](20) NOT NULL,
	[Nacionalidade] [varchar](100) NOT NULL,
	[GrauInstrucao] [varchar](100) NOT NULL,
	[InstituicaoEnsino] [varchar](100) NOT NULL,
	[TelefoneIES] [varchar](20) NOT NULL,
	[Curso] [varchar](8000) NULL,
	[HorarioAulaIES] [varchar](100) NOT NULL,
	[PeriodoAtual] [varchar](100) NOT NULL,
	[ColacaoGrau] [varchar](100) NOT NULL,
	[Agencia] [varchar](100) NOT NULL,
	[NomeAgencia] [varchar](100) NOT NULL,
	[ContaCorrente] [varchar](100) NOT NULL,
	[Uf] [varchar](2) NOT NULL,
	[OrgaoEmissor] [varchar](10) NOT NULL,
 CONSTRAINT [PK_dbo.Convocados] PRIMARY KEY CLUSTERED 
(
	[ConvocadoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DADOS_CONTATO]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DADOS_CONTATO](
	[CODIGO_PESSOA] [varchar](15) NOT NULL,
	[E_MAIL] [varchar](60) NOT NULL,
	[CEP] [varchar](15) NOT NULL,
	[TIPO_DE_LOGRADOURO] [varchar](4) NOT NULL,
	[ENDERECO] [varchar](40) NOT NULL,
	[NUMERO] [varchar](10) NOT NULL,
	[COMPLEMENTO] [varchar](40) NULL,
	[ESTADO] [varchar](4) NOT NULL,
	[CIDADE] [varchar](25) NOT NULL,
	[BAIRRO] [varchar](40) NOT NULL,
	[ID_CONCURSO] [int] NULL,
 CONSTRAINT [PK_DADOS_CONTATO] PRIMARY KEY CLUSTERED 
(
	[CODIGO_PESSOA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DADOS_PESSOAIS]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DADOS_PESSOAIS](
	[CODIGO] [varchar](15) NOT NULL,
	[NOME] [varchar](60) NOT NULL,
	[NACIONALIDADE] [varchar](4) NOT NULL,
	[NATURALIDADE_UF] [varchar](4) NOT NULL,
	[MUNICIPIO] [varchar](15) NOT NULL,
	[DATA_DE_NASCIMENTO] [date] NOT NULL,
	[SEXO] [varchar](4) NOT NULL,
	[ESTADO_CIVIL] [varchar](4) NOT NULL,
	[RG] [varchar](20) NOT NULL,
	[DATA_EXPEDICAO_RG] [date] NOT NULL,
	[ORGAO_EXPEDITOR_RG] [varchar](30) NOT NULL,
	[UF_RG] [varchar](2) NOT NULL,
	[NECESSIDADES_ESPECIAIS] [varchar](4) NOT NULL,
	[DATA_E_NASCIMENTO2] [nvarchar](10) NULL,
	[ID_CONCURSO] [int] NULL,
	[DATA_EXPEDICAO_RG2] [nvarchar](10) NULL,
 CONSTRAINT [PK_DADOS_PESSOAIS] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentoCandidato]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentoCandidato](
	[DocumentoCandidatoId] [uniqueidentifier] NOT NULL,
	[ProcessoId] [uniqueidentifier] NOT NULL,
	[ConvocadoId] [uniqueidentifier] NOT NULL,
	[Documento] [varchar](100) NOT NULL,
	[DataInclusao] [datetime] NOT NULL,
	[Path] [varchar](200) NOT NULL,
	[Ativo] [varchar](8000) NOT NULL,
	[TipoDocumento] [varchar](100) NOT NULL,
 CONSTRAINT [PK_DocumentoCandidato] PRIMARY KEY CLUSTERED 
(
	[DocumentoCandidatoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Documentos]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documentos](
	[DocumentoId] [uniqueidentifier] NOT NULL,
	[ProcessoId] [uniqueidentifier] NOT NULL,
	[Descricao] [varchar](100) NOT NULL,
	[DataCriacao] [datetime] NOT NULL,
	[Path] [varchar](200) NOT NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Documentos] PRIMARY KEY CLUSTERED 
(
	[DocumentoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pessoa]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pessoa](
	[PessoaId] [uniqueidentifier] NOT NULL,
	[Nome] [varchar](100) NULL,
	[Naturalidade] [varchar](100) NULL,
	[Mae] [varchar](100) NULL,
	[Pai] [varchar](100) NULL,
	[Documento] [varchar](30) NULL,
	[OrgaoEmissor] [varchar](10) NULL,
	[Sexo] [int] NULL,
	[EstadoCivil] [int] NULL,
	[DataNascimento] [datetime] NULL,
	[Filhos] [int] NULL,
	[Endereco] [varchar](100) NULL,
	[Numero] [varchar](6) NULL,
	[Complemento] [varchar](100) NULL,
	[Bairro] [varchar](100) NULL,
	[Cep] [varchar](8) NULL,
	[Cidade] [varchar](100) NULL,
	[Uf] [varchar](2) NULL,
	[Cargo] [varchar](6) NULL,
	[Deficiente] [bit] NULL,
	[Deficiencia] [varchar](100) NULL,
	[CondicaoEspecial] [varchar](100) NULL,
	[Cpf] [varchar](11) NULL,
	[Email] [varchar](100) NULL,
	[Afro] [bit] NULL,
	[Telefone] [varchar](20) NULL,
	[DataCadastro] [datetime] NULL,
 CONSTRAINT [PK_Pessoa] PRIMARY KEY CLUSTERED 
(
	[PessoaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrimeiroAcesso]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrimeiroAcesso](
	[PrimeiroAcessoId] [uniqueidentifier] NOT NULL,
	[Email] [varchar](200) NOT NULL,
	[Data] [datetime] NOT NULL,
	[ConvocadoId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_PrimeiroAcesso] PRIMARY KEY CLUSTERED 
(
	[PrimeiroAcessoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Processos]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Processos](
	[ProcessoId] [uniqueidentifier] NOT NULL,
	[ClienteId] [uniqueidentifier] NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[DataCriacao] [datetime] NOT NULL,
	[TextoDeAceitacaoDaConvocacao] [varchar](200) NOT NULL,
	[TextoInicialTelaConvocado] [varchar](200) NOT NULL,
	[TextoParaDesistentes] [varchar](200) NOT NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Processos] PRIMARY KEY CLUSTERED 
(
	[ProcessoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telefone]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefone](
	[TelefoneId] [uniqueidentifier] NOT NULL,
	[Ddd] [varchar](2) NOT NULL,
	[Numero] [varchar](11) NOT NULL,
	[PessoaId_PessoaId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Telefone] PRIMARY KEY CLUSTERED 
(
	[TelefoneId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TELEFONES]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TELEFONES](
	[ID_TELEFONE] [int] NOT NULL,
	[CODIGO_PESSOA] [varchar](15) NULL,
	[COD_TIPO_TELEFONE] [varchar](4) NULL,
	[DDD] [varchar](2) NULL,
	[TELEFONE] [varchar](15) NULL,
	[ACEITA_SMS] [varchar](1) NULL,
 CONSTRAINT [PK_TELEFONES] PRIMARY KEY CLUSTERED 
(
	[ID_TELEFONE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[TipoDocumentoId] [uniqueidentifier] NOT NULL,
	[TipoDocumentos] [varchar](100) NOT NULL,
	[Ativo] [bit] NOT NULL,
	[ProcessoId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[TipoDocumentoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 13/08/2020 18:16:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[UsuarioId] [uniqueidentifier] NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Login] [varchar](20) NOT NULL,
	[Senha] [varchar](10) NOT NULL,
	[Perfil] [varchar](1) NOT NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 13/08/2020 18:16:40 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 13/08/2020 18:16:40 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 13/08/2020 18:16:40 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 13/08/2020 18:16:40 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 13/08/2020 18:16:40 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 13/08/2020 18:16:40 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 13/08/2020 18:16:40 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Cargos_ProcessoId]    Script Date: 13/08/2020 18:16:40 ******/
CREATE NONCLUSTERED INDEX [IX_Cargos_ProcessoId] ON [dbo].[Cargos]
(
	[ProcessoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Documentos_ProcessoId]    Script Date: 13/08/2020 18:16:40 ******/
CREATE NONCLUSTERED INDEX [IX_Documentos_ProcessoId] ON [dbo].[Documentos]
(
	[ProcessoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Processos_ClienteId]    Script Date: 13/08/2020 18:16:40 ******/
CREATE NONCLUSTERED INDEX [IX_Processos_ClienteId] ON [dbo].[Processos]
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Telefone_PessoaId_PessoaId]    Script Date: 13/08/2020 18:16:40 ******/
CREATE NONCLUSTERED INDEX [IX_Telefone_PessoaId_PessoaId] ON [dbo].[Telefone]
(
	[PessoaId_PessoaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Admin] ADD  DEFAULT (newsequentialid()) FOR [AdminId]
GO
ALTER TABLE [dbo].[Cargos] ADD  DEFAULT (newsequentialid()) FOR [CargoId]
GO
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT (newsequentialid()) FOR [ClienteId]
GO
ALTER TABLE [dbo].[Convocacoes] ADD  DEFAULT (newsequentialid()) FOR [ConvocacaoId]
GO
ALTER TABLE [dbo].[Convocados] ADD  DEFAULT (newsequentialid()) FOR [ConvocadoId]
GO
ALTER TABLE [dbo].[Convocados] ADD  DEFAULT ('') FOR [FatorSanguineo]
GO
ALTER TABLE [dbo].[Convocados] ADD  DEFAULT ('') FOR [Doador]
GO
ALTER TABLE [dbo].[Convocados] ADD  DEFAULT ('') FOR [Recados]
GO
ALTER TABLE [dbo].[Convocados] ADD  DEFAULT ('') FOR [Nacionalidade]
GO
ALTER TABLE [dbo].[Convocados] ADD  DEFAULT ('') FOR [GrauInstrucao]
GO
ALTER TABLE [dbo].[Convocados] ADD  DEFAULT ('') FOR [InstituicaoEnsino]
GO
ALTER TABLE [dbo].[Convocados] ADD  DEFAULT ('') FOR [HorarioAulaIES]
GO
ALTER TABLE [dbo].[Convocados] ADD  DEFAULT ('') FOR [PeriodoAtual]
GO
ALTER TABLE [dbo].[Convocados] ADD  DEFAULT ('') FOR [ColacaoGrau]
GO
ALTER TABLE [dbo].[Convocados] ADD  DEFAULT ('') FOR [Agencia]
GO
ALTER TABLE [dbo].[Convocados] ADD  DEFAULT ('') FOR [NomeAgencia]
GO
ALTER TABLE [dbo].[Convocados] ADD  DEFAULT ('') FOR [ContaCorrente]
GO
ALTER TABLE [dbo].[Convocados] ADD  DEFAULT ('') FOR [Uf]
GO
ALTER TABLE [dbo].[Convocados] ADD  DEFAULT ('') FOR [OrgaoEmissor]
GO
ALTER TABLE [dbo].[DocumentoCandidato] ADD  DEFAULT (newsequentialid()) FOR [DocumentoCandidatoId]
GO
ALTER TABLE [dbo].[DocumentoCandidato] ADD  DEFAULT ('') FOR [TipoDocumento]
GO
ALTER TABLE [dbo].[Pessoa] ADD  DEFAULT (newsequentialid()) FOR [PessoaId]
GO
ALTER TABLE [dbo].[PrimeiroAcesso] ADD  DEFAULT (newsequentialid()) FOR [PrimeiroAcessoId]
GO
ALTER TABLE [dbo].[Processos] ADD  DEFAULT (newsequentialid()) FOR [ProcessoId]
GO
ALTER TABLE [dbo].[Telefone] ADD  DEFAULT (newsequentialid()) FOR [TelefoneId]
GO
ALTER TABLE [dbo].[TipoDocumento] ADD  DEFAULT (newsequentialid()) FOR [TipoDocumentoId]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT (newsequentialid()) FOR [UsuarioId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Cargos]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Cargos_dbo.Processos_ProcessoId] FOREIGN KEY([ProcessoId])
REFERENCES [dbo].[Processos] ([ProcessoId])
GO
ALTER TABLE [dbo].[Cargos] CHECK CONSTRAINT [FK_dbo.Cargos_dbo.Processos_ProcessoId]
GO
ALTER TABLE [dbo].[Documentos]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Documentos_dbo.Processos_ProcessoId] FOREIGN KEY([ProcessoId])
REFERENCES [dbo].[Processos] ([ProcessoId])
GO
ALTER TABLE [dbo].[Documentos] CHECK CONSTRAINT [FK_dbo.Documentos_dbo.Processos_ProcessoId]
GO
ALTER TABLE [dbo].[Processos]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Processos_dbo.Clientes_ClienteId] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Clientes] ([ClienteId])
GO
ALTER TABLE [dbo].[Processos] CHECK CONSTRAINT [FK_dbo.Processos_dbo.Clientes_ClienteId]
GO
ALTER TABLE [dbo].[Telefone]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Telefone_dbo.Pessoa_PessoaId_PessoaId] FOREIGN KEY([PessoaId_PessoaId])
REFERENCES [dbo].[Pessoa] ([PessoaId])
GO
ALTER TABLE [dbo].[Telefone] CHECK CONSTRAINT [FK_dbo.Telefone_dbo.Pessoa_PessoaId_PessoaId]
GO
USE [master]
GO
ALTER DATABASE [SisConvCore] SET  READ_WRITE 
GO
