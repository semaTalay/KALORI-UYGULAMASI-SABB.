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
    public class DietitianConfiguration : IEntityTypeConfiguration<Dietitian>
    {
        public void Configure(EntityTypeBuilder<Dietitian> builder)
        {
            builder.Property(d => d.Id).HasColumnName("DietitianId");
        }
    }
}
