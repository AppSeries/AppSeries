using Microsoft.EntityFrameworkCore.Migrations;

namespace SeriesApp.WebApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email_usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apelido_usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    senha_usuario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_usuarios");
        }
    }
}
