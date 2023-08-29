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
    public class UbigeoConfiguration : IEntityTypeConfiguration<UbigeoModel>
    {
        public void Configure(EntityTypeBuilder<UbigeoModel> builder)
        {
            builder.ToTable("Ubigeo").HasKey(x => x.UbigeoCode);
        }
    }
}
