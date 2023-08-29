using LibeyTechnicalTest.Backend.Domain.Models;
using LibeyTechnicalTest.Backend.Domain.Repositories;
using LibeyTechnicalTest.Backend.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Infrastructure.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly Context context;
        public RegionRepository(Context context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<RegionModel>> Get()
        {
            var regions = await context.Regions.ToListAsync();
            return regions;
        }
    }
}
