using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SQl_Lab2.Models;

public partial class Lab1DbContext : DbContext
{
    public Lab1DbContext()
    {
    }

    public Lab1DbContext(DbContextOptions<Lab1DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Butiker> Butikers { get; set; }

    public virtual DbSet<Böcker> Böckers { get; set; }

    public virtual DbSet<Författare> Författares { get; set; }

    public virtual DbSet<Förlag> Förlags { get; set; }

    public virtual DbSet<Kunder> Kunders { get; set; }

    public virtual DbSet<LagerSaldo> LagerSaldos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:alxithsserver.database.windows.net,1433;Initial Catalog=Lab1;Persist Security Info=False;User ID=AlxITHS;Password=Oakleaf96!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Butiker>(entity =>
        {
            entity.HasKey(e => e.ButikId).HasName("PK__Butiker__B5D66BFA498EDF40");

            entity.ToTable("Butiker");

            entity.Property(e => e.ButikId).HasColumnName("ButikID");
            entity.Property(e => e.ButiksNamn).HasMaxLength(50);
            entity.Property(e => e.Gata).HasMaxLength(50);
            entity.Property(e => e.GatuNummer).HasMaxLength(50);
        });

        modelBuilder.Entity<Böcker>(entity =>
        {
            entity.HasKey(e => e.Isbn).HasName("PK__Böcker__447D36EB2B545335");

            entity.ToTable("Böcker");

            entity.Property(e => e.Isbn)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ISBN");
            entity.Property(e => e.FörfattareId).HasColumnName("FörfattareID");
            entity.Property(e => e.FörlagId).HasColumnName("FörlagID");
            entity.Property(e => e.Kategori).HasMaxLength(50);
            entity.Property(e => e.Pris).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Språk).HasMaxLength(50);
            entity.Property(e => e.Titel).HasMaxLength(50);

            entity.HasOne(d => d.Författare).WithMany(p => p.Böckers)
                .HasForeignKey(d => d.FörfattareId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Böcker__Författa__29221CFB");

            entity.HasOne(d => d.Förlag).WithMany(p => p.Böckers)
                .HasForeignKey(d => d.FörlagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Böcker__FörlagID__2A164134");
        });

        modelBuilder.Entity<Författare>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Författa__3214EC27297E678D");

            entity.ToTable("Författare");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EfterNamn).HasMaxLength(200);
            entity.Property(e => e.FörNamn).HasMaxLength(200);
        });

        modelBuilder.Entity<Förlag>(entity =>
        {
            entity.HasKey(e => e.FörlagId).HasName("PK__Förlag__DE6A852C74E32959");

            entity.ToTable("Förlag");

            entity.Property(e => e.FörlagId).HasColumnName("FörlagID");
            entity.Property(e => e.Namn).HasMaxLength(50);
        });

        modelBuilder.Entity<Kunder>(entity =>
        {
            entity.HasKey(e => e.KundId).HasName("PK__Kunder__F2B5DEAC835A627F");

            entity.ToTable("Kunder");

            entity.Property(e => e.KundId).HasColumnName("KundID");
            entity.Property(e => e.Adress).HasMaxLength(200);
            entity.Property(e => e.EfterNamn).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FörNamn).HasMaxLength(200);
            entity.Property(e => e.Nummer).HasMaxLength(200);
        });

        modelBuilder.Entity<LagerSaldo>(entity =>
        {
            entity.HasKey(e => e.LagerId).HasName("PK__LagerSal__23FED8A917AE06D1");

            entity.ToTable("LagerSaldo");

            entity.Property(e => e.LagerId).HasColumnName("LagerID");
            entity.Property(e => e.ButikId).HasColumnName("ButikID");
            entity.Property(e => e.Isbn)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ISBN");

            entity.HasOne(d => d.Butik).WithMany(p => p.LagerSaldos)
                .HasForeignKey(d => d.ButikId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LagerSald__Butik__76969D2E");

            entity.HasOne(d => d.IsbnNavigation).WithMany(p => p.LagerSaldos)
                .HasForeignKey(d => d.Isbn)
                .HasConstraintName("FK_LagerSaldo_ISBN");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
