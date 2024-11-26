using Microsoft.EntityFrameworkCore;

namespace ComicRentalSystem.Models
{
    public class ComicSystemContext : DbContext
    {
        public ComicSystemContext(DbContextOptions<ComicSystemContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<ComicBook> ComicBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình kiểu dữ liệu cho thuộc tính Price trong ComicBook
            modelBuilder.Entity<ComicBook>()
                .Property(c => c.Price)
                .HasColumnType("decimal(18, 2)");
        }
    }
}
