using Microsoft.EntityFrameworkCore;
using ShopTest.Configuration;
using ShopTest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest.Context
{
    public partial class ApplicationContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductStoreConfig());
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfiguration(new BreadDepConfig());
            modelBuilder.ApplyConfiguration(new FishDepConfig());
            modelBuilder.ApplyConfiguration(new MeatDepConfig());
            modelBuilder.ApplyConfiguration(new MilkDepConfig());
            modelBuilder.ApplyConfiguration(new ManagerConfig());

            modelBuilder.Entity<ProductStore>().HasData(new ProductStore { Id = 1, Name_Store = "ПродуктЗБС", Address_Store = "Москва", Phone_Store = "984", Email_Store = "prod@mail.ru" });

            modelBuilder.Entity<Department>().HasData(new Department { Id = 1, Name_Department = "Мясной", ProductStore_Id = 1 });
            modelBuilder.Entity<Department>().HasData(new Department { Id = 2, Name_Department = "Рыбный", ProductStore_Id = 1 });
            modelBuilder.Entity<Department>().HasData(new Department { Id = 3, Name_Department = "Молочный", ProductStore_Id = 1 });
            modelBuilder.Entity<Department>().HasData(new Department { Id = 4, Name_Department = "Хлебный", ProductStore_Id = 1 });

            modelBuilder.Entity<MeatDep>().HasData(new MeatDep { Id = 1, Name_Prod = "Говядина", Weight = 100, Price = 800, ProductStore_Id = 1, Department_Id = 1 });
            modelBuilder.Entity<MeatDep>().HasData(new MeatDep { Id = 2, Name_Prod = "Курица", Weight = 100, Price = 500, ProductStore_Id = 1, Department_Id = 1 });
            modelBuilder.Entity<MeatDep>().HasData(new MeatDep { Id = 3, Name_Prod = "Индейка", Weight = 100, Price = 400, ProductStore_Id = 1, Department_Id = 1 });
            modelBuilder.Entity<MeatDep>().HasData(new MeatDep { Id = 4, Name_Prod = "Свинина", Weight = 100, Price = 900, ProductStore_Id = 1, Department_Id = 1 });
            modelBuilder.Entity<MeatDep>().HasData(new MeatDep { Id = 5, Name_Prod = "Утка", Weight = 100, Price = 300, ProductStore_Id = 1, Department_Id = 1 });

            modelBuilder.Entity<FishDep>().HasData(new FishDep { Id = 1, Name_Prod = "Осетр", Weight = 100, Price = 300, ProductStore_Id = 1, Department_Id = 2 });
            modelBuilder.Entity<FishDep>().HasData(new FishDep { Id = 2, Name_Prod = "Карась", Weight = 100, Price = 200, ProductStore_Id = 1, Department_Id = 2 });
            modelBuilder.Entity<FishDep>().HasData(new FishDep { Id = 3, Name_Prod = "Щука", Weight = 100, Price = 150, ProductStore_Id = 1, Department_Id = 2 });
            modelBuilder.Entity<FishDep>().HasData(new FishDep { Id = 4, Name_Prod = "Килька", Weight = 100, Price = 100, ProductStore_Id = 1, Department_Id = 2 });
            modelBuilder.Entity<FishDep>().HasData(new FishDep { Id = 5, Name_Prod = "Сельдь", Weight = 100, Price = 400, ProductStore_Id = 1, Department_Id = 2 });

            modelBuilder.Entity<MilkDep>().HasData(new MilkDep { Id = 1, Name_Prod = "Коровье", Count = 100, Price = 80, ProductStore_Id = 1, Department_Id = 3 });
            modelBuilder.Entity<MilkDep>().HasData(new MilkDep { Id = 2, Name_Prod = "Козье", Count = 100, Price = 90, ProductStore_Id = 1, Department_Id = 3 });
            modelBuilder.Entity<MilkDep>().HasData(new MilkDep { Id = 3, Name_Prod = "Оленье", Count = 100, Price = 150, ProductStore_Id = 1, Department_Id = 3 });
            modelBuilder.Entity<MilkDep>().HasData(new MilkDep { Id = 4, Name_Prod = "Кобылье", Count = 100, Price = 150, ProductStore_Id = 1, Department_Id = 3 });
            modelBuilder.Entity<MilkDep>().HasData(new MilkDep { Id = 5, Name_Prod = "Кролика", Count = 100, Price = 100, ProductStore_Id = 1, Department_Id = 3 });

            modelBuilder.Entity<BreadDep>().HasData(new BreadDep { Id = 1, Name_Prod = "Ржаной", Count = 100, Price = 40, ProductStore_Id = 1, Department_Id = 4 });
            modelBuilder.Entity<BreadDep>().HasData(new BreadDep { Id = 2, Name_Prod = "Белый", Count = 100, Price = 50, ProductStore_Id = 1, Department_Id = 4 });
            modelBuilder.Entity<BreadDep>().HasData(new BreadDep { Id = 3, Name_Prod = "Бездрожжевой", Count = 100, Price = 80, ProductStore_Id = 1, Department_Id = 4 });
            modelBuilder.Entity<BreadDep>().HasData(new BreadDep { Id = 4, Name_Prod = "Белковый", Count = 100, Price = 90, ProductStore_Id = 1, Department_Id = 4 });
            modelBuilder.Entity<BreadDep>().HasData(new BreadDep { Id = 5, Name_Prod = "Лаваш", Count = 100, Price = 40, ProductStore_Id = 1, Department_Id = 4 });

            modelBuilder.Entity<Department>().HasOne(u => u.ProductStore).
                WithMany(c => c.Departments).
                HasForeignKey(u => u.ProductStore_Id).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Manager>().HasOne(u => u.ProductStore).
                WithMany(c => c.Managers).
                HasForeignKey(u => u.ProductStore_Id).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Manager>().HasOne(u => u.Department).
                WithMany(c => c.Managers).
                HasForeignKey(u => u.Department_Id).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BreadDep>().HasOne(u => u.ProductStore).
                WithMany(c => c.Breads).
                HasForeignKey(u => u.ProductStore_Id).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BreadDep>().HasOne(u => u.Department).
                WithMany(c => c.Breads).
                HasForeignKey(u => u.Department_Id).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FishDep>().HasOne(u => u.ProductStore).
                WithMany(c => c.Fish).
                HasForeignKey(u => u.ProductStore_Id).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FishDep>().HasOne(u => u.Department).
                WithMany(c => c.Fish).
                HasForeignKey(u => u.Department_Id).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MeatDep>().HasOne(u => u.ProductStore).
                WithMany(c => c.Meat).
                HasForeignKey(u => u.ProductStore_Id).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MeatDep>().HasOne(u => u.Department).
                WithMany(c => c.Meat).
                HasForeignKey(u => u.Department_Id).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MilkDep>().HasOne(u => u.ProductStore).
                WithMany(c => c.Milk).
                HasForeignKey(u => u.ProductStore_Id).
                OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MilkDep>().HasOne(u => u.Department).
                WithMany(c => c.Milk).
                HasForeignKey(u => u.Department_Id).
                OnDelete(DeleteBehavior.Cascade);
        }
    }
}
