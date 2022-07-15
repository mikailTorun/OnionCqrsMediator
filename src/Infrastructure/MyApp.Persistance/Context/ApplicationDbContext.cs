using Application.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Persistance.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product() {Id = Guid.NewGuid(),Name="name 1",Quantity = 5,Value = 12},
                new Product() {Id = Guid.NewGuid(),Name="name 2",Quantity = 56,Value = 120},
                new Product() {Id = Guid.NewGuid(),Name="name 3",Quantity = 66,Value = 128}
            );
        }
    }
}
