using CarManagementAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CarManagementAPI.DbContext
{
    public class CarDbContext : IdentityDbContext<ApplicationUser>
    {
        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options)
        {
        }

        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CommissionData> CommissionData { get; set; }
        public DbSet<SalesData> SalesData { get; set; }
        public DbSet<PreviousYearSales> PreviousYearSales { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CarModel>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            builder.Entity<CommissionData>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            builder.Entity<SalesData>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            builder.Entity<PreviousYearSales>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            builder.Entity<CommissionData>().HasData(
                new CommissionData { Id = 1, Brand = "Audi", FixedCommission = 800, Threshold = 25000, ClassACommission = 0.08, ClassBCommission = 0.06, ClassCCommission = 0.04 },
                new CommissionData { Id = 2, Brand = "Jaguar", FixedCommission = 750, Threshold = 35000, ClassACommission = 0.06, ClassBCommission = 0.05, ClassCCommission = 0.03 },
                new CommissionData { Id = 3, Brand = "Land Rover", FixedCommission = 850, Threshold = 30000, ClassACommission = 0.07, ClassBCommission = 0.05, ClassCCommission = 0.04 },
                new CommissionData { Id = 4, Brand = "Renault", FixedCommission = 400, Threshold = 20000, ClassACommission = 0.05, ClassBCommission = 0.03, ClassCCommission = 0.02 }
            );

            builder.Entity<PreviousYearSales>().HasData(
            new PreviousYearSales { Id = 1, Salesman = "Salesman 1", LastYearSales = 490000 },
            new PreviousYearSales { Id = 2, Salesman = "Salesman 2", LastYearSales = 1000000 },
            new PreviousYearSales { Id = 3, Salesman = "Salesman 3", LastYearSales = 650000 }
        );

            builder.Entity<SalesData>().HasData(
                new SalesData { Id = 1, Salesman = "Salesman 1", Class = "A", Brand = "Audi", NumberOfCarsSold = 1, ModelPrice = 30000 },
                new SalesData { Id = 2, Salesman = "Salesman 1", Class = "A", Brand = "Jaguar", NumberOfCarsSold = 3, ModelPrice = 40000 },
                new SalesData { Id = 3, Salesman = "Salesman 1", Class = "A", Brand = "Land Rover", NumberOfCarsSold = 0, ModelPrice = 35000 },
                new SalesData { Id = 4, Salesman = "Salesman 1", Class = "A", Brand = "Renault", NumberOfCarsSold = 6, ModelPrice = 25000 },
                new SalesData { Id = 5, Salesman = "Salesman 1", Class = "B", Brand = "Audi", NumberOfCarsSold = 2, ModelPrice = 28000 },
                new SalesData { Id = 6, Salesman = "Salesman 1", Class = "B", Brand = "Jaguar", NumberOfCarsSold = 4, ModelPrice = 36000 },
                new SalesData { Id = 7, Salesman = "Salesman 1", Class = "B", Brand = "Land Rover", NumberOfCarsSold = 2, ModelPrice = 32000 },
                new SalesData { Id = 8, Salesman = "Salesman 1", Class = "B", Brand = "Renault", NumberOfCarsSold = 2, ModelPrice = 22000 },
                new SalesData { Id = 9, Salesman = "Salesman 1", Class = "C", Brand = "Audi", NumberOfCarsSold = 3, ModelPrice = 26000 },
                new SalesData { Id = 10, Salesman = "Salesman 1", Class = "C", Brand = "Jaguar", NumberOfCarsSold = 6, ModelPrice = 34000 },
                new SalesData { Id = 11, Salesman = "Salesman 1", Class = "C", Brand = "Land Rover", NumberOfCarsSold = 1, ModelPrice = 31000 },
                new SalesData { Id = 12, Salesman = "Salesman 1", Class = "C", Brand = "Renault", NumberOfCarsSold = 1, ModelPrice = 21000 },
                new SalesData { Id = 13, Salesman = "Salesman 2", Class = "A", Brand = "Audi", NumberOfCarsSold = 0, ModelPrice = 30000 },
                new SalesData { Id = 14, Salesman = "Salesman 2", Class = "A", Brand = "Jaguar", NumberOfCarsSold = 5, ModelPrice = 40000 },
                new SalesData { Id = 15, Salesman = "Salesman 2", Class = "A", Brand = "Land Rover", NumberOfCarsSold = 5, ModelPrice = 35000 },
                new SalesData { Id = 16, Salesman = "Salesman 2", Class = "A", Brand = "Renault", NumberOfCarsSold = 3, ModelPrice = 25000 },
                new SalesData { Id = 17, Salesman = "Salesman 2", Class = "B", Brand = "Audi", NumberOfCarsSold = 0, ModelPrice = 28000 },
                new SalesData { Id = 18, Salesman = "Salesman 2", Class = "B", Brand = "Jaguar", NumberOfCarsSold = 4, ModelPrice = 36000 },
                new SalesData { Id = 19, Salesman = "Salesman 2", Class = "B", Brand = "Land Rover", NumberOfCarsSold = 2, ModelPrice = 32000 },
                new SalesData { Id = 20, Salesman = "Salesman 2", Class = "B", Brand = "Renault", NumberOfCarsSold = 2, ModelPrice = 22000 },
                new SalesData { Id = 21, Salesman = "Salesman 2", Class = "C", Brand = "Audi", NumberOfCarsSold = 0, ModelPrice = 26000 },
                new SalesData { Id = 22, Salesman = "Salesman 2", Class = "C", Brand = "Jaguar", NumberOfCarsSold = 2, ModelPrice = 34000 },
                new SalesData { Id = 23, Salesman = "Salesman 2", Class = "C", Brand = "Land Rover", NumberOfCarsSold = 1, ModelPrice = 31000 },
                new SalesData { Id = 24, Salesman = "Salesman 2", Class = "C", Brand = "Renault", NumberOfCarsSold = 1, ModelPrice = 21000 },
                new SalesData { Id = 25, Salesman = "Salesman 3", Class = "A", Brand = "Audi", NumberOfCarsSold = 4, ModelPrice = 30000 },
                new SalesData { Id = 26, Salesman = "Salesman 3", Class = "A", Brand = "Jaguar", NumberOfCarsSold = 2, ModelPrice = 40000 },
                new SalesData { Id = 27, Salesman = "Salesman 3", Class = "A", Brand = "Land Rover", NumberOfCarsSold = 1, ModelPrice = 35000 },
                new SalesData { Id = 28, Salesman = "Salesman 3", Class = "A", Brand = "Renault", NumberOfCarsSold = 6, ModelPrice = 25000 },
                new SalesData { Id = 29, Salesman = "Salesman 3", Class = "B", Brand = "Audi", NumberOfCarsSold = 2, ModelPrice = 28000 },
                new SalesData { Id = 30, Salesman = "Salesman 3", Class = "B", Brand = "Jaguar", NumberOfCarsSold = 7, ModelPrice = 36000 },
                new SalesData { Id = 31, Salesman = "Salesman 3", Class = "B", Brand = "Land Rover", NumberOfCarsSold = 2, ModelPrice = 32000 },
                new SalesData { Id = 32, Salesman = "Salesman 3", Class = "B", Brand = "Renault", NumberOfCarsSold = 3, ModelPrice = 22000 },
                new SalesData { Id = 33, Salesman = "Salesman 3", Class = "C", Brand = "Audi", NumberOfCarsSold = 0, ModelPrice = 26000 },
                new SalesData { Id = 34, Salesman = "Salesman 3", Class = "C", Brand = "Jaguar", NumberOfCarsSold = 1, ModelPrice = 34000 },
                new SalesData { Id = 35, Salesman = "Salesman 3", Class = "C", Brand = "Land Rover", NumberOfCarsSold = 3, ModelPrice = 31000 },
                new SalesData { Id = 36, Salesman = "Salesman 3", Class = "C", Brand = "Renault", NumberOfCarsSold = 1, ModelPrice = 21000 }
            );
        }
    }
}
