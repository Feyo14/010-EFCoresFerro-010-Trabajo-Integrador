﻿// <auto-generated />
using EFCoresFerro.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoresFerro.Datos.Migrations
{
    [DbContext(typeof(EFCoresDbContext))]
    [Migration("20240807002905_agregarTablaShoeSize")]
    partial class agregarTablaShoeSize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCore3.Entidades.Brands", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"));

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("BrandId");

                    b.HasIndex("BrandName")
                        .IsUnique();

                    b.HasIndex(new[] { "BrandName" }, "IX_Brands_Name");

                    b.ToTable("Brands", (string)null);
                });

            modelBuilder.Entity("EFCore3.Entidades.Colors", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorId"));

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ColorId");

                    b.HasIndex("ColorName")
                        .IsUnique();

                    b.HasIndex(new[] { "ColorName" }, "IX_Color_Name");

                    b.ToTable("Colors", (string)null);
                });

            modelBuilder.Entity("EFCore3.Entidades.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("GenreId");

                    b.HasIndex("GenreName")
                        .IsUnique();

                    b.HasIndex(new[] { "GenreName" }, "IX_Genre_Name");

                    b.ToTable("Genre", (string)null);
                });

            modelBuilder.Entity("EFCore3.Entidades.Shoes", b =>
                {
                    b.Property<int>("ShoeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoeId"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("SportId")
                        .HasColumnType("int");

                    b.HasKey("ShoeId");

                    b.HasIndex(new[] { "BrandId" }, "FK_Shoes_BrandId");

                    b.HasIndex(new[] { "GenreId" }, "FK_Shoes_GenreId");

                    b.HasIndex(new[] { "SportId" }, "FK_Shoes_SportId");

                    b.ToTable("Shoes", (string)null);
                });

            modelBuilder.Entity("EFCore3.Entidades.Sports", b =>
                {
                    b.Property<int>("SportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SportId"));

                    b.Property<string>("SportName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("SportId");

                    b.HasIndex(new[] { "SportName" }, "IX_Sport_Name");

                    b.ToTable("Sports", (string)null);
                });

            modelBuilder.Entity("EFCoreFerro2.Datos.Deporte", b =>
                {
                    b.Property<int>("DeporteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeporteId"));

                    b.Property<string>("DeporteName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DeporteId");

                    b.HasIndex(new[] { "DeporteName" }, "IX_Deporte_Name");

                    b.ToTable("Deporte", (string)null);
                });

            modelBuilder.Entity("EFCoreFerro2.Datos.Genero", b =>
                {
                    b.Property<int>("GeneroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GeneroId"));

                    b.Property<string>("GeneroName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GeneroId");

                    b.HasIndex(new[] { "GeneroName" }, "IX_Genero_Name");

                    b.ToTable("Genero", (string)null);
                });

            modelBuilder.Entity("EFCoreFerro2.Datos.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarcaId"));

                    b.Property<string>("MarcaName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MarcaId");

                    b.HasIndex(new[] { "MarcaId" }, "FK_Zapatilla_MarcaId");

                    b.HasIndex(new[] { "MarcaName" }, "IX_Marca_Name");

                    b.ToTable("Marca", (string)null);
                });

            modelBuilder.Entity("EFCoreFerro2.Datos.Zapatilla", b =>
                {
                    b.Property<int>("ZapatillaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZapatillaId"));

                    b.Property<int>("DeporteId")
                        .HasColumnType("int");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("NombreZapatilla")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("ZapatillaId");

                    b.HasIndex("DeporteId");

                    b.HasIndex("GeneroId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Zapatilla", (string)null);
                });

            modelBuilder.Entity("EFCore3.Entidades.Shoes", b =>
                {
                    b.HasOne("EFCore3.Entidades.Brands", "brand")
                        .WithMany("shoes")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Shoes_BrandId");

                    b.HasOne("EFCore3.Entidades.Genre", "genre")
                        .WithMany("shoes")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Shoes_GenreId");

                    b.HasOne("EFCore3.Entidades.Sports", "sport")
                        .WithMany("shoes")
                        .HasForeignKey("SportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Shoes_SportId");

                    b.Navigation("brand");

                    b.Navigation("genre");

                    b.Navigation("sport");
                });

            modelBuilder.Entity("EFCoreFerro2.Datos.Zapatilla", b =>
                {
                    b.HasOne("EFCoreFerro2.Datos.Deporte", "Deporte")
                        .WithMany("Zapatillas")
                        .HasForeignKey("DeporteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreFerro2.Datos.Genero", "Genero")
                        .WithMany("Zapatillas")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreFerro2.Datos.Marca", "Marca")
                        .WithMany("Zapatillas")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deporte");

                    b.Navigation("Genero");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("EFCore3.Entidades.Brands", b =>
                {
                    b.Navigation("shoes");
                });

            modelBuilder.Entity("EFCore3.Entidades.Genre", b =>
                {
                    b.Navigation("shoes");
                });

            modelBuilder.Entity("EFCore3.Entidades.Sports", b =>
                {
                    b.Navigation("shoes");
                });

            modelBuilder.Entity("EFCoreFerro2.Datos.Deporte", b =>
                {
                    b.Navigation("Zapatillas");
                });

            modelBuilder.Entity("EFCoreFerro2.Datos.Genero", b =>
                {
                    b.Navigation("Zapatillas");
                });

            modelBuilder.Entity("EFCoreFerro2.Datos.Marca", b =>
                {
                    b.Navigation("Zapatillas");
                });
#pragma warning restore 612, 618
        }
    }
}
