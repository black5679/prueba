using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Application.Queries.LibeyUser.GetByDocumentNumber
{
    public class GetByDocumentNumberLibeyUserResponse
    {
        public string DocumentNumber { get; init; }
        public int DocumentTypeId { get; init; }
        public string Name { get; init; }
        public string FathersLastName { get; init; }
        public string MothersLastName { get; init; }
        public string Address { get; init; }
        public string RegionCode { get; init; }
        public string ProvinceCode { get; init; }
        public string UbigeoCode { get; init; }
        public string Phone { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }
        public bool Active { get; init; }
    }
}
