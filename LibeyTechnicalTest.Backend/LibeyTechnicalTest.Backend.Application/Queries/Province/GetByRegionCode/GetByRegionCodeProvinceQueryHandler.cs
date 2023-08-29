using LibeyTechnicalTest.Backend.Domain.Models;
using LibeyTechnicalTest.Backend.Domain.Repositories;
using MediatR;

namespace LibeyTechnicalTest.Backend.Application.Queries.Province.GetByRegionCode
{
    public class GetByRegionCodeProvinceQueryHandler : IRequestHandler<GetByRegionCodeProvinceQuery, IEnumerable<ProvinceModel>>
    {
        private readonly IProvinceRepository provinceRepository;
        public GetByRegionCodeProvinceQueryHandler(IProvinceRepository provinceRepository)
        {
            this.provinceRepository = provinceRepository;
        }
        public async Task<IEnumerable<ProvinceModel>> Handle(GetByRegionCodeProvinceQuery request, CancellationToken cancellationToken)
        {
            var response = await provinceRepository.GetByRegionCode(request.RegionCode);
            return response;
        }
    }
}
