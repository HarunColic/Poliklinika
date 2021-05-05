using Microsoft.EntityFrameworkCore.Migrations;

namespace PoliklinikaAPI.Migrations
{
    public partial class editedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Korisnik_Ime",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Korisnik_Prezime",
                table: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Korisnik_Ime",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Korisnik_Prezime",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
