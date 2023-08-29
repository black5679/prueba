using LibeyTechnicalTest.Backend.Infrastructure.EFCore.Configuration;
using LibeyTechnicalTest.Backend.Domain.Models;
using Microsoft.EntityFrameworkCore;
namespace LibeyTechnicalTest.Backend.Infrastructure.EFCore
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<LibeyUserModel> LibeyUsers { get; set; }
        public DbSet<DocumentTypeModel> DocumentTypes { get; set; }
        public DbSet<ProvinceModel> Provinces { get; set; }
        public DbSet<RegionModel> Regions { get; set; }
        public DbSet<UbigeoModel> Ubigeos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LibeyUserConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProvinceConfiguration());
            modelBuilder.ApplyConfiguration(new RegionConfiguration());
            modelBuilder.ApplyConfiguration(new UbigeoConfiguration());
        }
    }
}