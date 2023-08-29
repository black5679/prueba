using LibeyTechnicalTest.Backend.Application.Common;
using MediatR;

namespace LibeyTechnicalTest.Backend.Application.Commands.LibeyUser.Update
{
    public class UpdateLibeyUserCommand : IRequest<ResponseModel>
    {
        public required string DocumentNumber { get; set; }
        public required string Name { get; set; }
        public required string FathersLastName { get; set; }
        public required string MothersLastName { get; set; }
        public required string Address { get; set; }
        public required string UbigeoCode { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
    }
}
