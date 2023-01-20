using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TP_Final_Bingo.Models;

namespace TP_Final_Bingo.Context;

public partial class BingoContext : DbContext
{
    public BingoContext()
    {
    }

    public BingoContext(DbContextOptions<BingoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HistorialBolillero> HistorialBolilleros { get; set; }

    public virtual DbSet<HistorialCartone> HistorialCartones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-QR7T2GC;Database=Bingo;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HistorialBolillero>(entity =>
        {
            entity.ToTable("HistorialBolillero");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FechaHora)
                .HasColumnType("datetime")
                .HasColumnName("fecha_hora");
            entity.Property(e => e.Numero).HasColumnName("numero");
        });

        modelBuilder.Entity<HistorialCartone>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Carton1).HasColumnName("carton1");
            entity.Property(e => e.Carton2).HasColumnName("carton2");
            entity.Property(e => e.Carton3).HasColumnName("carton3");
            entity.Property(e => e.Carton4).HasColumnName("carton4");
            entity.Property(e => e.FechaHora)
                .HasColumnType("datetime")
                .HasColumnName("fecha_hora");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
