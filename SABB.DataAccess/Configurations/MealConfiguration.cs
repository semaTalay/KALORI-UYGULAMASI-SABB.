using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SABB.Domain.Abstract;
using SABB.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.DataAccess.Configurations
{
    public class MealConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.Property(m => m.MealId).HasColumnName("MealId").IsRequired();
            builder.Property(m => m.UserId).HasColumnName("UserId").IsRequired();
            //builder.Property(m => m.FoodId).HasColumnName("FoodId").IsRequired();
            builder.Property(m => m.Date).IsRequired();
            builder.Property(m => m.MealType).IsRequired();
            builder.Property(m => m.TotalCalorie).IsRequired();
            //builder.HasIndex(m => new { m.MealId, m.UserId, m.FoodId, m.Date, m.MealType }).IsUnique();
            builder.HasIndex(m => new { m.UserId, m.Date, m.MealType }).IsUnique();

            //builder.HasOne(m => m.User).WithMany(u => u.Meals).HasForeignKey(m => m.UserId);
            //builder.HasOne(m => m.Food).WithMany().HasForeignKey(m => m.FoodId);

            
        }
    }
}
