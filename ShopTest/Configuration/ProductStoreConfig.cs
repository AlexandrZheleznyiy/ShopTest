using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopTest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest.Configuration
{
    public class ProductStoreConfig : IEntityTypeConfiguration<ProductStore>
    {
        public void Configure(EntityTypeBuilder<ProductStore> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name_Store).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Address_Store).HasMaxLength(100);
            builder.HasIndex(p => p.Phone_Store).IsUnique();
            builder.Property(p => p.Phone_Store).HasMaxLength(100);
            builder.HasIndex(p => p.Email_Store).IsUnique();
            builder.Property(p => p.Email_Store).HasMaxLength(100);
        }
    }
}
