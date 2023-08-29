using LibeyTechnicalTest.Backend.Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Application.Commands.LibeyUser.Insert
{
    public class InsertLibeyUserCommand : IRequest<ResponseModel>
    {
        public required string DocumentNumber { get; set; }
        public required int DocumentTypeId { get; set; }
        public required string Name { get; set; }
        public required string FathersLastName { get; set; }
        public required string MothersLastName { get; set; }
        public required string Address { get; set; }
        public required string UbigeoCode { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
