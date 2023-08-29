using LibeyTechnicalTest.Backend.Domain.Models;
using LibeyTechnicalTest.Backend.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Application.Queries.Ubigeo.GetByProvinceCode
{
    public class GetByProvinceCodeUbigeoQueryHandler : IRequestHandler<GetByProvinceCodeUbigeoQuery, IEnumerable<UbigeoModel>>
    {
        private readonly IUbigeoRepository ubigeoRepository;
        public GetByProvinceCodeUbigeoQueryHandler(IUbigeoRepository ubigeoRepository)
        {
            this.ubigeoRepository = ubigeoRepository;
        }
        public async Task<IEnumerable<UbigeoModel>> Handle(GetByProvinceCodeUbigeoQuery request, CancellationToken cancellationToken)
        {
            var response = await ubigeoRepository.GetByProvinceCode(request.ProvinceCode);
            return response;
        }
    }
}
