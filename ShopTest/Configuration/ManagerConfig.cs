using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopTest.Entity;

namespace ShopTest.Configuration
{
    public class ManagerConfig : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasMaxLength(100);
            builder.Property(p => p.LastName).HasMaxLength(100);
            builder.Property(p => p.Age).HasDefaultValue(18);
            builder.HasIndex(p => p.Phone).IsUnique();
            builder.Property(p => p.Phone).HasMaxLength(100);
            builder.HasIndex(p => p.Email).IsUnique();
            builder.Property(p => p.Email).HasMaxLength(100);
            builder.Property(p => p.ProductStore_Id).ValueGeneratedNever();
            builder.Property(p => p.Department_Id).ValueGeneratedNever();
        }
    }
}
