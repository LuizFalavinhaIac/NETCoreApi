using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLoja.Migrations
{
    public partial class adduow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataVenda",
                table: "Produto");

            migrationBuilder.AddColumn<long>(
                name: "CategoriaId",
                table: "Produto",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fornecedor",
                table: "Produto",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Fornecedor",
                table: "Produto");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataVenda",
                table: "Produto",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
