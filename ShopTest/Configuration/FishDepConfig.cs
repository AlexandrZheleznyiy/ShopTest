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
    public class FishDepConfig : IEntityTypeConfiguration<FishDep>
    {
        public void Configure(EntityTypeBuilder<FishDep> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name_Prod).HasMaxLength(100);
            builder.Property(p => p.Weight);
            builder.Property(p => p.Price);
            builder.Property(p => p.ProductStore_Id).ValueGeneratedNever();
            builder.Property(p => p.Department_Id).ValueGeneratedNever();
        }
    }
}
