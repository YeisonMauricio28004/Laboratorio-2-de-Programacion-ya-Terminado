using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio2.Models;

public partial class NotaEstudianteContext : DbContext
{
    public NotaEstudianteContext()
    {
    }

    public NotaEstudianteContext(DbContextOptions<NotaEstudianteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Notum> Nota { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-CKS5AM2I;Database=NotaEstudiante;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Notum>(entity =>
        {
            entity.HasKey(e => e.IdNotas).HasName("PK__Nota__858E853D3B284A81");

            entity.Property(e => e.Lab1).HasColumnType("decimal(16, 2)");
            entity.Property(e => e.Lab2).HasColumnType("decimal(16, 2)");
            entity.Property(e => e.Lab3).HasColumnType("decimal(16, 2)");
            entity.Property(e => e.NombreEstudiante)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Parcial1).HasColumnType("decimal(16, 2)");
            entity.Property(e => e.Parcial2).HasColumnType("decimal(16, 2)");
            entity.Property(e => e.Parcial3).HasColumnType("decimal(16, 2)");
            entity.Property(e => e.Resultado).HasColumnType("decimal(16, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
