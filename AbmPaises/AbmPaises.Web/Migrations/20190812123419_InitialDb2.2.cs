using Microsoft.EntityFrameworkCore.Migrations;

namespace AbmPaises.Web.Migrations
{
    public partial class InitialDb22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreCiudad",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "NombreProvincia",
                table: "Paises");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NombreCiudad",
                table: "Paises",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombreProvincia",
                table: "Paises",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
