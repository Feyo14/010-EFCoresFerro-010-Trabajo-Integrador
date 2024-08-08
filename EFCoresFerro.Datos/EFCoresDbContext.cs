using EFCore3.Entidades;
using EFCoreFerro2.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoresFerro.Datos;

public partial class EFCoresDbContext : DbContext
{
    public EFCoresDbContext()
    {
    }

    public EFCoresDbContext(DbContextOptions<EFCoresDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Brands> Brands { get; set; }

    public virtual DbSet<Colors> Colors { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Shoes> Shoes { get; set; }

    public virtual DbSet<Sports> Sports { get; set; }


    public virtual DbSet<Deporte> Deportes { get; set; }

    public virtual DbSet<Genero> Generos { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Zapatilla> Zapatillas { get; set; }

    public virtual DbSet<Size> Size { get; set; }
    public virtual DbSet<ShoeSize> ShoeSize { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=EFCoresFerro; Trusted_Connection=true; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
        modelBuilder.Entity<Brands>(entity =>
        {
            entity.ToTable("Brands");


            entity.HasKey(e => e.BrandId);
            entity.HasIndex(e => e.BrandName, "IX_Brands_Name");

            entity.Property(e => e.BrandName).HasMaxLength(50);
            entity.HasIndex(e => e.BrandName).IsUnique();

        });

        modelBuilder.Entity<Colors>(entity =>
        {
            entity.ToTable("Colors");

            entity.HasKey(e => e.ColorId);
            entity.HasIndex(e => e.ColorName, "IX_Color_Name");
            entity.HasIndex(e => e.ColorName).IsUnique();

            entity.Property(e => e.ColorName).HasMaxLength(50);
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.ToTable("Genre");

            entity.HasKey(e => e.GenreId);
            entity.ToTable("Genre");
            entity.HasIndex(e => e.GenreName).IsUnique();

            entity.HasIndex(e => e.GenreName, "IX_Genre_Name");

            entity.Property(e => e.GenreName).HasMaxLength(10);
        });

        modelBuilder.Entity<Shoes>(entity =>
        {
            entity.ToTable("Shoes");

            entity.HasKey(e => e.ShoeId);
            entity.HasIndex(e => e.BrandId, "FK_Shoes_BrandId");

             entity.HasIndex(e => e.GenreId, "FK_Shoes_GenreId");

             entity.HasIndex(e => e.SportId, "FK_Shoes_SportId");




               entity.HasOne(d => d.brand).WithMany(p => p.shoes)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK_Shoes_BrandId");
              entity.HasOne(d => d.genre).WithMany(p => p.shoes)
              .HasForeignKey(d => d.GenreId)
               .HasConstraintName("FK_Shoes_GenreId");
               entity.HasOne(d => d.sport).WithMany(p => p.shoes)
               .HasForeignKey(d => d.SportId)
                .HasConstraintName("FK_Shoes_SportId");


            entity.Property(e => e.Model).HasMaxLength(150);
            entity.Property(e => e.Descripcion)
               .HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Sports>(entity =>
        {
            entity.ToTable("Sports");

            entity.HasKey(e => e.SportId);
            entity.HasIndex(e => e.SportName, "IX_Sport_Name");

            entity.Property(e => e.SportName).HasMaxLength(20);
        });


        modelBuilder.Entity<Deporte>(entity =>
        {
            entity.ToTable("Deporte");

            entity.HasIndex(e => e.DeporteName, "IX_Deporte_Name");

            entity.Property(e => e.DeporteName).HasMaxLength(50);
        });

        modelBuilder.Entity<Genero>(entity =>
        {
            entity.ToTable("Genero");

            entity.HasIndex(e => e.GeneroName, "IX_Genero_Name");

            entity.Property(e => e.GeneroName).HasMaxLength(50);
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.ToTable("Marca");

            entity.HasIndex(e => e.MarcaId, "FK_Zapatilla_MarcaId");

            entity.HasIndex(e => e.MarcaName, "IX_Marca_Name");

            entity.Property(e => e.MarcaName).HasMaxLength(50);
        });

        modelBuilder.Entity<Zapatilla>(entity =>
        {
            entity.ToTable("Zapatilla");

            entity.Property(e => e.NombreZapatilla).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Deporte).WithMany(p => p.Zapatillas).HasForeignKey(d => d.DeporteId);

            entity.HasOne(d => d.Genero).WithMany(p => p.Zapatillas).HasForeignKey(d => d.GeneroId);

            entity.HasOne(d => d.Marca).WithMany(p => p.Zapatillas).HasForeignKey(d => d.MarcaId);
        });
        modelBuilder.Entity<Size>(entity =>
        {
            entity.ToTable("Size");


            entity.HasKey(e => e.SizeId);
            entity.HasIndex(e => e.SizeId, "IX_Size");

            entity.HasIndex(e => e.sizeNumber).IsUnique();

        });
        modelBuilder.Entity<ShoeSize>(entity =>
        {
            entity.ToTable("ShoeSizes");


            entity.HasKey(e => e.ShoeSizeId);
            entity.HasIndex(e => e.QuantityInStock, "IX_QuantityInStock");
            entity.HasOne(d => d.Shoe).WithMany(p => p.shoesize).HasForeignKey(d => d.ShoeId);
            entity.HasOne(d => d.Size).WithMany(p => p.shoesize).HasForeignKey(d => d.SizeId);

        });
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
