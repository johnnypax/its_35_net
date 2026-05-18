using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace lez08_videoteca.models;

public partial class Ict35VideotecaContext : DbContext
{
    public Ict35VideotecaContext()
    {
    }

    public Ict35VideotecaContext(DbContextOptions<Ict35VideotecaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Prestito> Prestitos { get; set; }

    public virtual DbSet<Utente> Utentes { get; set; }

    public virtual DbSet<Videocassettum> Videocassetta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=BOOK-N57JVKH6HJ\\SQLEXPRESS;Database=ict_35_videoteca;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Prestito>(entity =>
        {
            entity.HasKey(e => new { e.VideocassettaRif, e.UtenteRif }).HasName("PK__Prestito__F0B3001601B601B4");

            entity.ToTable("Prestito");

            entity.Property(e => e.VideocassettaRif).HasColumnName("videocassettaRIF");
            entity.Property(e => e.UtenteRif).HasColumnName("utenteRIF");
            entity.Property(e => e.DataPrestito)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("data_prestito");

            entity.HasOne(d => d.UtenteRifNavigation).WithMany(p => p.Prestitos)
                .HasForeignKey(d => d.UtenteRif)
                .HasConstraintName("FK__Prestito__utente__2D27B809");

            entity.HasOne(d => d.VideocassettaRifNavigation).WithMany(p => p.Prestitos)
                .HasForeignKey(d => d.VideocassettaRif)
                .HasConstraintName("FK__Prestito__videoc__2C3393D0");
        });

        modelBuilder.Entity<Utente>(entity =>
        {
            entity.HasKey(e => e.UtenteId).HasName("PK__Utente__CA5C2253D86D8F39");

            entity.ToTable("Utente");

            entity.HasIndex(e => e.Email, "UQ__Utente__AB6E6164A98DC7DE").IsUnique();

            entity.Property(e => e.UtenteId).HasColumnName("utenteID");
            entity.Property(e => e.Cognome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("cognome");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Videocassettum>(entity =>
        {
            entity.HasKey(e => e.VideocassettaId).HasName("PK__Videocas__F824370A990436EA");

            entity.HasIndex(e => e.Codice, "UQ__Videocas__40F9C18BA53004A6").IsUnique();

            entity.Property(e => e.VideocassettaId).HasColumnName("videocassettaID");
            entity.Property(e => e.Anno).HasColumnName("anno");
            entity.Property(e => e.Codice)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("codice");
            entity.Property(e => e.Genere)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("N.D.")
                .HasColumnName("genere");
            entity.Property(e => e.Regista)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("regista");
            entity.Property(e => e.Titolo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("titolo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
