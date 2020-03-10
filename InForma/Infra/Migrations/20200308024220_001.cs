using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class _001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Professor",
                table: "Turmas");

            migrationBuilder.AddColumn<int>(
                name: "ColaboradorId",
                table: "Turmas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    CPF = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    RG = table.Column<string>(nullable: true),
                    CEP = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colaboradores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: true),
                    RG = table.Column<string>(nullable: true),
                    Endereço = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    FuncaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboradores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colaboradores_Funcoes_FuncaoId",
                        column: x => x.FuncaoId,
                        principalTable: "Funcoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Turmas_ColaboradorId",
                table: "Turmas",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_FuncaoId",
                table: "Colaboradores",
                column: "FuncaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Turmas_Colaboradores_ColaboradorId",
                table: "Turmas",
                column: "ColaboradorId",
                principalTable: "Colaboradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turmas_Colaboradores_ColaboradorId",
                table: "Turmas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Colaboradores");

            migrationBuilder.DropIndex(
                name: "IX_Turmas_ColaboradorId",
                table: "Turmas");

            migrationBuilder.DropColumn(
                name: "ColaboradorId",
                table: "Turmas");

            migrationBuilder.AddColumn<string>(
                name: "Professor",
                table: "Turmas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
