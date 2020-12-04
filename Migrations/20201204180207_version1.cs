using Microsoft.EntityFrameworkCore.Migrations;

namespace Repara_Ya__App.Migrations
{
    public partial class version1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdquirirTable",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdquirirTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IngresarAdquirirTable",
                columns: table => new
                {
                    LoginID = table.Column<string>(type: "varchar(255)", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    Contraseña = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresarAdquirirTable", x => x.LoginID);
                });

            migrationBuilder.CreateTable(
                name: "IngresarOfrecerTable",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(255)", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    Contraseña = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresarOfrecerTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoginAdquirirTable",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginAdquirirTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoginOfrecerTable",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginOfrecerTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OfrecerTable",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfrecerTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QuieroAdquirirUnServicioTable",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuieroAdquirirUnServicioTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QuieroOfrecerTable",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuieroOfrecerTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RegistrateAdquirirTable",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(255)", nullable: false),
                    Nombre = table.Column<string>(type: "longtext", nullable: true),
                    Apellidos = table.Column<string>(type: "longtext", nullable: true),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    Contraseña = table.Column<string>(type: "longtext", nullable: true),
                    Ciudad = table.Column<string>(type: "longtext", nullable: true),
                    Direccion = table.Column<string>(type: "longtext", nullable: true),
                    Celular = table.Column<int>(type: "int", nullable: false),
                    Pais = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrateAdquirirTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RegistrateOfrecerTable",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(255)", nullable: false),
                    Nombre = table.Column<string>(type: "longtext", nullable: true),
                    Apellidos = table.Column<string>(type: "longtext", nullable: true),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    Ciudad = table.Column<string>(type: "longtext", nullable: true),
                    Direccion = table.Column<string>(type: "longtext", nullable: true),
                    Celular = table.Column<int>(type: "int", nullable: false),
                    Pais = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrateOfrecerTable", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdquirirTable");

            migrationBuilder.DropTable(
                name: "IngresarAdquirirTable");

            migrationBuilder.DropTable(
                name: "IngresarOfrecerTable");

            migrationBuilder.DropTable(
                name: "LoginAdquirirTable");

            migrationBuilder.DropTable(
                name: "LoginOfrecerTable");

            migrationBuilder.DropTable(
                name: "OfrecerTable");

            migrationBuilder.DropTable(
                name: "QuieroAdquirirUnServicioTable");

            migrationBuilder.DropTable(
                name: "QuieroOfrecerTable");

            migrationBuilder.DropTable(
                name: "RegistrateAdquirirTable");

            migrationBuilder.DropTable(
                name: "RegistrateOfrecerTable");
        }
    }
}
