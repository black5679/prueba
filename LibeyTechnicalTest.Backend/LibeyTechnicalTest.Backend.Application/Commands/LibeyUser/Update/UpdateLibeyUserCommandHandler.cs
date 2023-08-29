using LibeyTechnicalTest.Backend.Application.Common;
using LibeyTechnicalTest.Backend.Domain.Models;
using LibeyTechnicalTest.Backend.Domain.Repositories;
using MediatR;

namespace LibeyTechnicalTest.Backend.Application.Commands.LibeyUser.Update
{
    public class UpdateLibeyUserCommandHandler : IRequestHandler<UpdateLibeyUserCommand, ResponseModel>
    {
        private readonly ILibeyUserRepository libeyUserRepository;
        public UpdateLibeyUserCommandHandler(ILibeyUserRepository libeyUserRepository)
        {
            this.libeyUserRepository = libeyUserRepository;
        }
        public async Task<ResponseModel> Handle(UpdateLibeyUserCommand request, CancellationToken cancellationToken)
        {
            await libeyUserRepository.Update(new LibeyUserModel(null, 0, request.Name, request.FathersLastName, request.MothersLastName, request.Address, request.UbigeoCode, request.Phone, request.Email, null));
            return new ResponseModel("Se modificó el usuario con éxito");
        }
    }
}
