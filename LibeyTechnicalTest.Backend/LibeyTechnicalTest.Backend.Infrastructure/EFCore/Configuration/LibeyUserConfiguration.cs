using LibeyTechnicalTest.Backend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace LibeyTechnicalTest.Backend.Infrastructure.EFCore.Configuration
{
    internal class LibeyUserConfiguration : IEntityTypeConfiguration<LibeyUserModel>
    {
        public void Configure(EntityTypeBuilder<LibeyUserModel> builder)
        {
            builder.ToTable("LibeyUser").HasKey(x => x.DocumentNumber);
        }
    }
}