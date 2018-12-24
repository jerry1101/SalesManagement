using Microsoft.EntityFrameworkCore;
using SalesManagement.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesManagement.Server.DataAccess
{
    public class SalesDbContext : DbContext
    {
        public virtual DbSet<Customer> Customer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=demofunc.database.windows.net;Initial Catalog=DemoBlazor;User ID=jhung;Password=Hhj1101@");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("SalesLT");
        }

    }
}
