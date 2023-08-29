using LibeyTechnicalTest.Backend.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Application.Queries.Province.GetByRegionCode
{
    public class GetByRegionCodeProvinceQuery : IRequest<IEnumerable<ProvinceModel>>
    {
        public required string RegionCode { get; set; }
    }
}
