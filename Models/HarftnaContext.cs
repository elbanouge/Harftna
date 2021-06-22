using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplicationHarftna.Models
{
    public partial class HarftnaContext : DbContext
    {
        public HarftnaContext()
        {
        }

        public HarftnaContext(DbContextOptions<HarftnaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrateur> Administrateurs { get; set; }
        public virtual DbSet<Avi> Avis { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Commander> Commanders { get; set; }
        public virtual DbSet<Fournisseur> Fournisseurs { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Informationpersonnelle> Informationpersonnelles { get; set; }
        public virtual DbSet<Livraison> Livraisons { get; set; }
        public virtual DbSet<Medium> Media { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }
        public virtual DbSet<Singler> Singlers { get; set; }
        public virtual DbSet<Societe> Societes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<Administrateur>(entity =>
            {
                entity.Property(e => e.Idad).ValueGeneratedNever();

                entity.Property(e => e.Loginad)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Passad)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Avi>(entity =>
            {
                entity.HasKey(e => new { e.Idcliavi, e.Idpavi });

                entity.HasOne(d => d.IdcliaviNavigation)
                    .WithMany(p => p.Avis)
                    .HasForeignKey(d => d.Idcliavi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENTAVI");

                entity.HasOne(d => d.IdpaviNavigation)
                    .WithMany(p => p.Avis)
                    .HasForeignKey(d => d.Idpavi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUITAVI");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.Idcli).ValueGeneratedNever();

                entity.Property(e => e.Cinpasscli)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Emailcli)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Ipcli)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Motpasscli)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Nomcli)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Prenomcli)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Scorecli)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Telcli)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Commander>(entity =>
            {
                entity.HasKey(e => new { e.Idpcom, e.Idinfocom, e.Idlivcom });

                entity.Property(e => e.Etatcom)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdinfocomNavigation)
                    .WithMany(p => p.Commanders)
                    .HasForeignKey(d => d.Idinfocom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INFORMATIONPERSONNELLECOM");

                entity.HasOne(d => d.IdlivcomNavigation)
                    .WithMany(p => p.Commanders)
                    .HasForeignKey(d => d.Idlivcom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LIVRAISONCOM");

                entity.HasOne(d => d.IdpcomNavigation)
                    .WithMany(p => p.Commanders)
                    .HasForeignKey(d => d.Idpcom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUITCOM");
            });

            modelBuilder.Entity<Fournisseur>(entity =>
            {
                entity.Property(e => e.Idfour).ValueGeneratedNever();

                entity.Property(e => e.Cinpassfour)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Domainefour)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Emailfour)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Faxfour)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Motpassfour)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Nomfour)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Prenomfour)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Telfour)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.Property(e => e.Idgen).ValueGeneratedNever();

                entity.Property(e => e.Typegen)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Informationpersonnelle>(entity =>
            {
                entity.Property(e => e.Idinfo).ValueGeneratedNever();

                entity.Property(e => e.Codepostalcliinfo)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Payscliinfo)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdcliinfoNavigation)
                    .WithMany(p => p.Informationpersonnelles)
                    .HasForeignKey(d => d.Idcliinfo)
                    .HasConstraintName("FK_CLIENTINFO");
            });

            modelBuilder.Entity<Livraison>(entity =>
            {
                entity.Property(e => e.Idliv).ValueGeneratedNever();

                entity.Property(e => e.Modeliv)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdsoslivNavigation)
                    .WithMany(p => p.Livraisons)
                    .HasForeignKey(d => d.Idsosliv)
                    .HasConstraintName("FK_SOCIETELIV");
            });

            modelBuilder.Entity<Medium>(entity =>
            {
                entity.Property(e => e.Idmed).ValueGeneratedNever();

                entity.HasOne(d => d.IdpmedNavigation)
                    .WithMany(p => p.Media)
                    .HasForeignKey(d => d.Idpmed)
                    .HasConstraintName("FK_PRODUITMED");
            });

            modelBuilder.Entity<Produit>(entity =>
            {
                entity.Property(e => e.Idpro).ValueGeneratedNever();

                entity.Property(e => e.Nompro)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Originpro)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdfrsproNavigation)
                    .WithMany(p => p.Produits)
                    .HasForeignKey(d => d.Idfrspro)
                    .HasConstraintName("FK_FOURNISSEURPRO");

                entity.HasOne(d => d.IdgproNavigation)
                    .WithMany(p => p.Produits)
                    .HasForeignKey(d => d.Idgpro)
                    .HasConstraintName("GENREPRO");
            });

            modelBuilder.Entity<Singler>(entity =>
            {
                entity.HasKey(e => new { e.Idclising, e.Idpsing });

                entity.HasOne(d => d.IdclisingNavigation)
                    .WithMany(p => p.Singlers)
                    .HasForeignKey(d => d.Idclising)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENTSING");

                entity.HasOne(d => d.IdpsingNavigation)
                    .WithMany(p => p.Singlers)
                    .HasForeignKey(d => d.Idpsing)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRODUITSING");
            });

            modelBuilder.Entity<Societe>(entity =>
            {
                entity.Property(e => e.Idsoc).ValueGeneratedNever();

                entity.Property(e => e.Nomsoc)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
