using BlossomAndCo.Models;
using Microsoft.EntityFrameworkCore;

namespace BlossomAndCo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Bouquet> Bouquets { get; set; }
        public DbSet<BouquetIngredients> BouquetIngredients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Flower>().ToTable("Flowers");
            modelBuilder.Entity<Plant>().ToTable("Plants");
            modelBuilder.Entity<Bouquet>().ToTable("Bouquets");

            modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<OrderItem>().Property(oi => oi.UnitPrice).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Order>().Property(o => o.TotalAmount).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<BouquetIngredients>()
                .HasOne(bi => bi.Flower)
                .WithMany()
                .HasForeignKey(bi => bi.FlowerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
