using Microsoft.EntityFrameworkCore;

namespace bontravailapi.Models {
    public class BonTravailContext : DbContext {
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }

        public BonTravailContext(DbContextOptions<BonTravailContext> options) : base(options)   {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Roles>().ToTable("roles");
            modelBuilder.Entity<Utilisateur>().ToTable("utilisateurs");

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.Utilisateurs)
                .WithOne(e => e.Role)
                .HasForeignKey(e => e.Role_id)
                .HasPrincipalKey(e => e.Id);

            modelBuilder.Entity<Utilisateur>()
                .HasOne(e => e.Role)
                .WithMany(e => e.Utilisateurs)
                .HasForeignKey(e => e.Role_id)
                .IsRequired();
        }
    }
}