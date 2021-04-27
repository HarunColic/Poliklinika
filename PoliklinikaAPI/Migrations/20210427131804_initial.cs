using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PoliklinikaAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Odjel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slika = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odjel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Raspored",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumOD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumDO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dokument = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raspored", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Korisnik_Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Korisnik_Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KrvnaGrupa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojRadneKnjizice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OdjelID = table.Column<int>(type: "int", nullable: true),
                    Specijalizacija = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubSpecijalizacija = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrucnaSprema = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_Odjel_OdjelID",
                        column: x => x.OdjelID,
                        principalTable: "Odjel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pregled",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoktorID = table.Column<int>(type: "int", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pregled", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pregled_User_DoktorID",
                        column: x => x.DoktorID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pregled_User_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RasporedOsoblje",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OsobljeID = table.Column<int>(type: "int", nullable: false),
                    RasporedID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RasporedOsoblje", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RasporedOsoblje_Raspored_RasporedID",
                        column: x => x.RasporedID,
                        principalTable: "Raspored",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RasporedOsoblje_User_OsobljeID",
                        column: x => x.OsobljeID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Izvjestaj",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PregledID = table.Column<int>(type: "int", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izvjestaj", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Izvjestaj_Pregled_PregledID",
                        column: x => x.PregledID,
                        principalTable: "Pregled",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nalaz",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PregledID = table.Column<int>(type: "int", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nalaz", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Nalaz_Pregled_PregledID",
                        column: x => x.PregledID,
                        principalTable: "Pregled",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PregledTehnicar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PregledID = table.Column<int>(type: "int", nullable: false),
                    TehnicarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PregledTehnicar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PregledTehnicar_Pregled_PregledID",
                        column: x => x.PregledID,
                        principalTable: "Pregled",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PregledTehnicar_User_TehnicarID",
                        column: x => x.TehnicarID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Uplata",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PregledID = table.Column<int>(type: "int", nullable: false),
                    Iznos = table.Column<float>(type: "real", nullable: false),
                    DatumUplate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplata", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Uplata_Pregled_PregledID",
                        column: x => x.PregledID,
                        principalTable: "Pregled",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Smjena",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RasporedOsobljeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smjena", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Smjena_RasporedOsoblje_RasporedOsobljeID",
                        column: x => x.RasporedOsobljeID,
                        principalTable: "RasporedOsoblje",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Izvjestaj_PregledID",
                table: "Izvjestaj",
                column: "PregledID");

            migrationBuilder.CreateIndex(
                name: "IX_Nalaz_PregledID",
                table: "Nalaz",
                column: "PregledID");

            migrationBuilder.CreateIndex(
                name: "IX_Pregled_DoktorID",
                table: "Pregled",
                column: "DoktorID");

            migrationBuilder.CreateIndex(
                name: "IX_Pregled_KorisnikID",
                table: "Pregled",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_PregledTehnicar_PregledID",
                table: "PregledTehnicar",
                column: "PregledID");

            migrationBuilder.CreateIndex(
                name: "IX_PregledTehnicar_TehnicarID",
                table: "PregledTehnicar",
                column: "TehnicarID");

            migrationBuilder.CreateIndex(
                name: "IX_RasporedOsoblje_OsobljeID",
                table: "RasporedOsoblje",
                column: "OsobljeID");

            migrationBuilder.CreateIndex(
                name: "IX_RasporedOsoblje_RasporedID",
                table: "RasporedOsoblje",
                column: "RasporedID");

            migrationBuilder.CreateIndex(
                name: "IX_Smjena_RasporedOsobljeID",
                table: "Smjena",
                column: "RasporedOsobljeID");

            migrationBuilder.CreateIndex(
                name: "IX_Uplata_PregledID",
                table: "Uplata",
                column: "PregledID");

            migrationBuilder.CreateIndex(
                name: "IX_User_OdjelID",
                table: "User",
                column: "OdjelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Izvjestaj");

            migrationBuilder.DropTable(
                name: "Nalaz");

            migrationBuilder.DropTable(
                name: "PregledTehnicar");

            migrationBuilder.DropTable(
                name: "Smjena");

            migrationBuilder.DropTable(
                name: "Uplata");

            migrationBuilder.DropTable(
                name: "RasporedOsoblje");

            migrationBuilder.DropTable(
                name: "Pregled");

            migrationBuilder.DropTable(
                name: "Raspored");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Odjel");
        }
    }
}
