using System;
using GC_CarDealership_API.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;



namespace GC_CarDealership_API.Data
{
    public class CarDbContext : DbContext
    {
        
        public CarDbContext(DbContextOptions<CarDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Car { get; set; }

    }
}
