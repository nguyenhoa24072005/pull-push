using ComicRentalSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ComicRentalSystem.Data
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

            // Tùy chọn cấu hình bảng
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<ComicBook>().ToTable("ComicBooks");
        }
    }
}
