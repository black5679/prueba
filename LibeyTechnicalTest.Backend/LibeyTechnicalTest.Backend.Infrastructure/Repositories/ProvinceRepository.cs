using LibeyTechnicalTest.Backend.Domain.Models;
using LibeyTechnicalTest.Backend.Domain.Repositories;
using LibeyTechnicalTest.Backend.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace LibeyTechnicalTest.Backend.Infrastructure.Repositories
{
    public class ProvinceRepository : IProvinceRepository
    {
        private readonly Context context;
        public ProvinceRepository(Context context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<ProvinceModel>> GetByRegionCode(string regionCode)
        {
            var provinces = await context.Provinces.Where(x => x.RegionCode == regionCode).ToListAsync();
            return provinces;
        }
    }
}
