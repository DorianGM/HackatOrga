using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace hackatOrga.Models
{
    public partial class pbaudoin_hackatonContext : DbContext
    {
        public pbaudoin_hackatonContext()
        {
        }

        public pbaudoin_hackatonContext(DbContextOptions<pbaudoin_hackatonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Evenement> Evenements { get; set; }
        public virtual DbSet<Hackathon> Hackathons { get; set; }
        public virtual DbSet<Inscription> Inscriptions { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=127.0.0.1;port=3307;user=root;database=pbaudoin_hackaton;sslmode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evenement>(entity =>
            {
                entity.HasKey(e => e.IdEvent)
                    .HasName("PRIMARY");

                entity.ToTable("evenement");

                entity.HasIndex(e => e.IdHackat, "crtx");

                entity.Property(e => e.IdEvent)
                    .HasColumnType("int(11)")
                    .HasColumnName("idEvent");

                entity.Property(e => e.DateE)
                    .HasColumnType("date")
                    .HasColumnName("dateE");

                entity.Property(e => e.DureeE).HasColumnName("dureeE");

                entity.Property(e => e.HeureE).HasColumnName("heureE");

                entity.Property(e => e.IdHackat)
                    .HasColumnType("int(11)")
                    .HasColumnName("idHackat");

                entity.Property(e => e.LibelleE)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("libelleE");

                entity.Property(e => e.SalleE)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("salleE");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.IdHackatNavigation)
                    .WithMany(p => p.Evenements)
                    .HasForeignKey(d => d.IdHackat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("crtx");
            });

            modelBuilder.Entity<Hackathon>(entity =>
            {
                entity.HasKey(e => e.IdH)
                    .HasName("PRIMARY");

                entity.ToTable("hackathon");

                entity.Property(e => e.IdH)
                    .HasColumnType("int(11)")
                    .HasColumnName("idH");

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(5)
                    .HasColumnName("codePostal")
                    .HasDefaultValueSql("'NULL'")
                    .IsFixedLength(true);

                entity.Property(e => e.DateDebut)
                    .HasColumnType("date")
                    .HasColumnName("dateDebut");

                entity.Property(e => e.DateFin)
                    .HasColumnType("date")
                    .HasColumnName("dateFin")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateLimite)
                    .HasColumnType("date")
                    .HasColumnName("dateLimite")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HeureDebut)
                    .HasColumnName("heureDebut")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HeureFin)
                    .HasColumnName("heureFin")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("image");

                entity.Property(e => e.Lieu)
                    .HasMaxLength(255)
                    .HasColumnName("lieu")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NbPlaces)
                    .HasColumnType("int(11)")
                    .HasColumnName("nbPlaces")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rue)
                    .HasMaxLength(255)
                    .HasColumnName("rue")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Theme)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("theme");

                entity.Property(e => e.Ville)
                    .HasMaxLength(255)
                    .HasColumnName("ville")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Inscription>(entity =>
            {
                entity.HasKey(e => e.IdI)
                    .HasName("PRIMARY");

                entity.ToTable("inscription");

                entity.HasIndex(e => e.IdHackathon, "idH");

                entity.HasIndex(e => e.IdParticipant, "idP");

                entity.Property(e => e.IdI)
                    .HasColumnType("int(10)")
                    .HasColumnName("idI");

                entity.Property(e => e.DateInscription)
                    .HasColumnType("date")
                    .HasColumnName("dateInscription")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.IdHackathon)
                    .HasColumnType("int(10)")
                    .HasColumnName("idHackathon");

                entity.Property(e => e.IdParticipant)
                    .HasColumnType("int(10)")
                    .HasColumnName("idParticipant");

                entity.Property(e => e.Texte)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("texte");

                entity.HasOne(d => d.IdHackathonNavigation)
                    .WithMany(p => p.Inscriptions)
                    .HasForeignKey(d => d.IdHackathon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("inscription_ibfk_1");

                entity.HasOne(d => d.IdParticipantNavigation)
                    .WithMany(p => p.Inscriptions)
                    .HasForeignKey(d => d.IdParticipant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("inscription_ibfk_2");
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.HasKey(e => e.IdP)
                    .HasName("PRIMARY");

                entity.ToTable("participant");

                entity.Property(e => e.IdP)
                    .HasColumnType("int(10)")
                    .HasColumnName("idP");

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("cp");

                entity.Property(e => e.DateNaiss)
                    .HasColumnType("date")
                    .HasColumnName("dateNaiss");

                entity.Property(e => e.Login)
                    .HasMaxLength(30)
                    .HasColumnName("login")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("mail");

                entity.Property(e => e.MdpHash)
                    .HasMaxLength(128)
                    .HasColumnName("mdpHash")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("nom");

                entity.Property(e => e.NumTel)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("numTel");

                entity.Property(e => e.Portfolio)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("portfolio");

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("prenom");

                entity.Property(e => e.Rue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("rue");

                entity.Property(e => e.Ville)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ville");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
