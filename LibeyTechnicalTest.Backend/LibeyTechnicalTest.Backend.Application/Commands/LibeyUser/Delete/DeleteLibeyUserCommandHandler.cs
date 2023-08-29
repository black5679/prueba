using LibeyTechnicalTest.Backend.Application.Common;
using LibeyTechnicalTest.Backend.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Application.Commands.LibeyUser.Delete
{
    public class DeleteLibeyUserCommandHandler : IRequestHandler<DeleteLibeyUserCommand, ResponseModel>
    {
        private readonly ILibeyUserRepository libeyUserRepository;
        public DeleteLibeyUserCommandHandler(ILibeyUserRepository libeyUserRepository)
        {
            this.libeyUserRepository = libeyUserRepository;
        }
        public async Task<ResponseModel> Handle(DeleteLibeyUserCommand request, CancellationToken cancellationToken)
        {
            await libeyUserRepository.Delete(request.DocumentNumber);
            return new ResponseModel("Se eliminó el usuario con éxito");
        }
    }
}
