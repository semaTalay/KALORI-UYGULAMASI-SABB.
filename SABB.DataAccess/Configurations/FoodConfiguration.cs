using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SABB.Domain.Abstract;
using SABB.Domain.Concrete;
using SABB.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.DataAccess.Configurations
{
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.Property(f => f.Id).HasColumnName("FoodId").IsRequired();
            builder.Property(f => f.Name).IsRequired();
            builder.Property(f => f.Calories).IsRequired();
            builder.Property(f => f.Description).IsRequired();
            builder.Property(f => f.Status).IsRequired();
            builder.Property(f => f.FoodType).IsRequired();

            builder.HasData(
                new Food 
                {
                    Id = 1,
                    Name = "Peynir",
                    Calories = 200,
                    Description = "Beyaz peynir",
                    FoodType = Domain.Enums.FoodType.Other,
                    Status = Domain.Enums.Status.Active
                },
                new Food 
                {
                    Id = 2,
                    Name = "Zeytin",
                    Calories = 150,
                    Description = "Siyah Zeytin",
                    FoodType = Domain.Enums.FoodType.Other,
                    Status = Domain.Enums.Status.Active
                },
                new Food 
                {
                    Id = 3,
                    Name = "Kebap",
                    Calories = 400,
                    Description = "Et Ürünü",
                    FoodType = Domain.Enums.FoodType.Meat,
                    Status = Domain.Enums.Status.Active
                }
                
                );
        }
    }
}
