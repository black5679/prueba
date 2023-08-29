using LibeyTechnicalTest.Backend.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Application.Queries.Ubigeo.GetByProvinceCode
{
    public class GetByProvinceCodeUbigeoQuery : IRequest<IEnumerable<UbigeoModel>>
    {
        public required string ProvinceCode { get; set; }
    }
}
