using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketForYou.Data.Migrations
{
    public partial class setup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comentario",
                columns: table => new
                {
                    comentarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricaoComentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usernameCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usernameFei = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    feiraID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentario", x => x.comentarioId);
                });

            migrationBuilder.CreateTable(
                name: "Feirante",
                columns: table => new
                {
                    usernameFei = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    emailFei = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passwordFei = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numVisitasFei = table.Column<int>(type: "int", nullable: false),
                    feiraID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feirante", x => x.usernameFei);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    produtoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoriaProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descricaoProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empresaID = table.Column<int>(type: "int", nullable: false),
                    feiraID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.produtoID);
                });

            migrationBuilder.CreateTable(
                name: "ReportErros",
                columns: table => new
                {
                    reportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    anexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descricaoErro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usernameCliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportErros", x => x.reportId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comentario");

            migrationBuilder.DropTable(
                name: "Feirante");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "ReportErros");
        }
    }
}
