﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PoliklinikaAPI.Data;

namespace PoliklinikaAPI.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20210531195056_timespanstring")]
    partial class timespanstring
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Poliklinika.Model.ChatObaveza", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminID")
                        .HasColumnType("int");

                    b.Property<int>("ObavezaID")
                        .HasColumnType("int");

                    b.Property<int>("OsobljeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AdminID");

                    b.HasIndex("ObavezaID");

                    b.HasIndex("OsobljeID");

                    b.ToTable("ChatObaveza");
                });

            modelBuilder.Entity("Poliklinika.Model.ChatPoruka", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChatObavezaID")
                        .HasColumnType("int");

                    b.Property<int>("OsobljeID")
                        .HasColumnType("int");

                    b.Property<string>("Poruka")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ChatObavezaID");

                    b.HasIndex("OsobljeID");

                    b.ToTable("ChatPoruka");
                });

            modelBuilder.Entity("Poliklinika.Model.Izvjestaj", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PregledID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PregledID");

                    b.ToTable("Izvjestaj");
                });

            modelBuilder.Entity("Poliklinika.Model.Nalaz", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PregledID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PregledID");

                    b.ToTable("Nalaz");
                });

            modelBuilder.Entity("Poliklinika.Model.Obaveza", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivna")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("OdjelID")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OsobljeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OdjelID");

                    b.HasIndex("OsobljeID");

                    b.ToTable("Obaveza");
                });

            modelBuilder.Entity("Poliklinika.Model.Odjel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ID");

                    b.ToTable("Odjel");
                });

            modelBuilder.Entity("Poliklinika.Model.Pregled", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DoktorID")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("OdjelID")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TehnicarID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DoktorID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("OdjelID");

                    b.HasIndex("TehnicarID");

                    b.ToTable("Pregled");
                });

            modelBuilder.Entity("Poliklinika.Model.Raspored", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoktorID")
                        .HasColumnType("int");

                    b.Property<int>("PregledID")
                        .HasColumnType("int");

                    b.Property<int>("TehnicarID")
                        .HasColumnType("int");

                    b.Property<string>("Vrijeme")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DoktorID");

                    b.HasIndex("PregledID");

                    b.HasIndex("TehnicarID");

                    b.ToTable("Raspored");
                });

            modelBuilder.Entity("Poliklinika.Model.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Poliklinika.Model.Uplata", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumUplate")
                        .HasColumnType("datetime2");

                    b.Property<float>("Iznos")
                        .HasColumnType("real");

                    b.Property<int>("PregledID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PregledID");

                    b.ToTable("Uplata");
                });

            modelBuilder.Entity("Poliklinika.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("Poliklinika.Model.Korisnik", b =>
                {
                    b.HasBaseType("Poliklinika.Model.User");

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("KrvnaGrupa")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Korisnik");
                });

            modelBuilder.Entity("Poliklinika.Model.Osoblje", b =>
                {
                    b.HasBaseType("Poliklinika.Model.User");

                    b.Property<string>("BrojRadneKnjizice")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Osoblje");
                });

            modelBuilder.Entity("Poliklinika.Model.Admin", b =>
                {
                    b.HasBaseType("Poliklinika.Model.Osoblje");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("Poliklinika.Model.Doktor", b =>
                {
                    b.HasBaseType("Poliklinika.Model.Osoblje");

                    b.Property<int>("OdjelID")
                        .HasColumnType("int");

                    b.Property<string>("Specijalizacija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubSpecijalizacija")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("OdjelID");

                    b.HasDiscriminator().HasValue("Doktor");
                });

            modelBuilder.Entity("Poliklinika.Model.Tehnicar", b =>
                {
                    b.HasBaseType("Poliklinika.Model.Osoblje");

                    b.Property<string>("StrucnaSprema")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Tehnicar");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Poliklinika.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Poliklinika.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Poliklinika.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Poliklinika.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Poliklinika.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Poliklinika.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Poliklinika.Model.ChatObaveza", b =>
                {
                    b.HasOne("Poliklinika.Model.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Poliklinika.Model.Obaveza", "Obaveza")
                        .WithMany()
                        .HasForeignKey("ObavezaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Poliklinika.Model.Osoblje", "Osoblje")
                        .WithMany()
                        .HasForeignKey("OsobljeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Obaveza");

                    b.Navigation("Osoblje");
                });

            modelBuilder.Entity("Poliklinika.Model.ChatPoruka", b =>
                {
                    b.HasOne("Poliklinika.Model.ChatObaveza", "ChatObaveza")
                        .WithMany()
                        .HasForeignKey("ChatObavezaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Poliklinika.Model.Osoblje", "Osoblje")
                        .WithMany()
                        .HasForeignKey("OsobljeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChatObaveza");

                    b.Navigation("Osoblje");
                });

            modelBuilder.Entity("Poliklinika.Model.Izvjestaj", b =>
                {
                    b.HasOne("Poliklinika.Model.Pregled", "Pregled")
                        .WithMany()
                        .HasForeignKey("PregledID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pregled");
                });

            modelBuilder.Entity("Poliklinika.Model.Nalaz", b =>
                {
                    b.HasOne("Poliklinika.Model.Pregled", "Pregled")
                        .WithMany()
                        .HasForeignKey("PregledID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pregled");
                });

            modelBuilder.Entity("Poliklinika.Model.Obaveza", b =>
                {
                    b.HasOne("Poliklinika.Model.Odjel", "Odjel")
                        .WithMany()
                        .HasForeignKey("OdjelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Poliklinika.Model.Osoblje", "Osoblje")
                        .WithMany()
                        .HasForeignKey("OsobljeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Odjel");

                    b.Navigation("Osoblje");
                });

            modelBuilder.Entity("Poliklinika.Model.Pregled", b =>
                {
                    b.HasOne("Poliklinika.Model.Doktor", "Doktor")
                        .WithMany()
                        .HasForeignKey("DoktorID");

                    b.HasOne("Poliklinika.Model.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Poliklinika.Model.Odjel", "Odjel")
                        .WithMany()
                        .HasForeignKey("OdjelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Poliklinika.Model.Tehnicar", "Tehnicar")
                        .WithMany()
                        .HasForeignKey("TehnicarID");

                    b.Navigation("Doktor");

                    b.Navigation("Korisnik");

                    b.Navigation("Odjel");

                    b.Navigation("Tehnicar");
                });

            modelBuilder.Entity("Poliklinika.Model.Raspored", b =>
                {
                    b.HasOne("Poliklinika.Model.Doktor", "Doktor")
                        .WithMany()
                        .HasForeignKey("DoktorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Poliklinika.Model.Pregled", "Pregled")
                        .WithMany()
                        .HasForeignKey("PregledID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Poliklinika.Model.Tehnicar", "Tehnicar")
                        .WithMany()
                        .HasForeignKey("TehnicarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doktor");

                    b.Navigation("Pregled");

                    b.Navigation("Tehnicar");
                });

            modelBuilder.Entity("Poliklinika.Model.Uplata", b =>
                {
                    b.HasOne("Poliklinika.Model.Pregled", "Pregled")
                        .WithMany()
                        .HasForeignKey("PregledID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pregled");
                });

            modelBuilder.Entity("Poliklinika.Model.Doktor", b =>
                {
                    b.HasOne("Poliklinika.Model.Odjel", "Odjel")
                        .WithMany()
                        .HasForeignKey("OdjelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Odjel");
                });
#pragma warning restore 612, 618
        }
    }
}
