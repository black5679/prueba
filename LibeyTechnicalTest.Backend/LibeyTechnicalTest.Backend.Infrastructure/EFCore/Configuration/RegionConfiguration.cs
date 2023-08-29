using LibeyTechnicalTest.Backend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Infrastructure.EFCore.Configuration
{
    public class RegionConfiguration : IEntityTypeConfiguration<RegionModel>
    {
        public void Configure(EntityTypeBuilder<RegionModel> builder)
        {
            builder.ToTable("Region").HasKey(x => x.RegionCode);
        }
    }
}
