using Microsoft.EntityFrameworkCore;
using ShopTest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest.Context
{
    public partial class ApplicationContext : DbContext
    {
        public DbSet<ProductStore> Store { get; set; } = null!;
        public DbSet<Department> Department { get; set; } = null!;
        public DbSet<BreadDep> Bread { get; set; } = null!;
        public DbSet<FishDep> Fish { get; set; } = null!;
        public DbSet<MeatDep> Meat { get; set; } = null!;
        public DbSet<MilkDep> Milk { get; set; } = null!;
        public DbSet<Manager> Managers { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ProdStore;Username=postgres;Password=1234");
        }
    }
}
