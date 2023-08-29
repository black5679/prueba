using LibeyTechnicalTest.Backend.Domain.Models;
using LibeyTechnicalTest.Backend.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Application.Queries.Region.Get
{
    public class GetRegionQueryHandler : IRequestHandler<GetRegionQuery, IEnumerable<RegionModel>>
    {
        private readonly IRegionRepository regionRepository;
        public GetRegionQueryHandler(IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
        }
        public async Task<IEnumerable<RegionModel>> Handle(GetRegionQuery request, CancellationToken cancellationToken)
        {
            var response = await regionRepository.Get();
            return response;
        }
    }
}
