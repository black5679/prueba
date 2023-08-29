using LibeyTechnicalTest.Backend.Domain.Models;
using LibeyTechnicalTest.Backend.Domain.Repositories;
using LibeyTechnicalTest.Backend.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace LibeyTechnicalTest.Backend.Infrastructure.Repositories
{
    public class UbigeoRepository : IUbigeoRepository
    {
        private readonly Context context;
        public UbigeoRepository(Context context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<UbigeoModel>> GetByProvinceCode(string provinceCode)
        {
            var ubigeo = await context.Ubigeos.Where(x => x.ProvinceCode == provinceCode).ToListAsync();
            return ubigeo;
        }
    }
}
