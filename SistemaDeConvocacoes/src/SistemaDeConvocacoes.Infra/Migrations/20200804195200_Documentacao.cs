using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaDeConvocacoes.Infra.Migrations
{
    public partial class Documentacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dbo.Telefone_dbo.Pessoa_PessoaId_PessoaId",
                table: "Telefone");

            migrationBuilder.DropTable(
                name: "TELEFONES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefone",
                table: "Telefone");

            migrationBuilder.DropIndex(
                name: "IX_Telefone_PessoaId_PessoaId",
                table: "Telefone");

            migrationBuilder.DropColumn(
                name: "TelefoneId",
                table: "Telefone");

            migrationBuilder.DropColumn(
                name: "PessoaId_PessoaId",
                table: "Telefone");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Telefone",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldUnicode: false,
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Ddd",
                table: "Telefone",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldUnicode: false,
                oldMaxLength: 2);

            migrationBuilder.AddColumn<int>(
                name: "IdTelefone",
                table: "Telefone",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "AceitaSms",
                table: "Telefone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodTipoTelefone",
                table: "Telefone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoPessoa",
                table: "Telefone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PessoaId",
                table: "Telefone",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefone",
                table: "Telefone",
                column: "IdTelefone");

            migrationBuilder.CreateTable(
                name: "Documentacao",
                columns: table => new
                {
                    DocumentoId = table.Column<Guid>(nullable: false),
                    ConvocacaoId = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Path = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.Documentacao", x => x.DocumentoId);
                    table.ForeignKey(
                        name: "FK_dbo.Documentos_dbo.Convocacao_ConvocacaoId",
                        column: x => x.ConvocacaoId,
                        principalTable: "Convocacoes",
                        principalColumn: "ConvocacaoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_PessoaId",
                table: "Telefone",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentacao_ConvocacaoId",
                table: "Documentacao",
                column: "ConvocacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_Pessoa_PessoaId",
                table: "Telefone",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_Pessoa_PessoaId",
                table: "Telefone");

            migrationBuilder.DropTable(
                name: "Documentacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefone",
                table: "Telefone");

            migrationBuilder.DropIndex(
                name: "IX_Telefone_PessoaId",
                table: "Telefone");

            migrationBuilder.DropColumn(
                name: "IdTelefone",
                table: "Telefone");

            migrationBuilder.DropColumn(
                name: "AceitaSms",
                table: "Telefone");

            migrationBuilder.DropColumn(
                name: "CodTipoTelefone",
                table: "Telefone");

            migrationBuilder.DropColumn(
                name: "CodigoPessoa",
                table: "Telefone");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Telefone");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Telefone",
                type: "varchar(11)",
                unicode: false,
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Ddd",
                table: "Telefone",
                type: "varchar(2)",
                unicode: false,
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2);

            migrationBuilder.AddColumn<Guid>(
                name: "TelefoneId",
                table: "Telefone",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "(newsequentialid())");

            migrationBuilder.AddColumn<Guid>(
                name: "PessoaId_PessoaId",
                table: "Telefone",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefone",
                table: "Telefone",
                column: "TelefoneId");

            migrationBuilder.CreateTable(
                name: "TELEFONES",
                columns: table => new
                {
                    ID_TELEFONE = table.Column<int>(type: "int", nullable: false),
                    ACEITA_SMS = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    COD_TIPO_TELEFONE = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    CODIGO_PESSOA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DDD = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    TELEFONE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TELEFONES", x => x.ID_TELEFONE);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_PessoaId_PessoaId",
                table: "Telefone",
                column: "PessoaId_PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_dbo.Telefone_dbo.Pessoa_PessoaId_PessoaId",
                table: "Telefone",
                column: "PessoaId_PessoaId",
                principalTable: "Pessoa",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
