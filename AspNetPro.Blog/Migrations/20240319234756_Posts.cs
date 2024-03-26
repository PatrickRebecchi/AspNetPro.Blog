using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetPro.Blog.Migrations
{
    /// <inheritdoc />
    public partial class Posts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    resumo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    conteudo = table.Column<string>(type: "NVARCHAR(MAX)", nullable: true),
                    dataPublicacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
