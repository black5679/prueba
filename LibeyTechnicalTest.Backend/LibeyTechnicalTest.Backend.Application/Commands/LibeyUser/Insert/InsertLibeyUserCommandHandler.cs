using LibeyTechnicalTest.Backend.Application.Common;
using LibeyTechnicalTest.Backend.Domain.Models;
using LibeyTechnicalTest.Backend.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Application.Commands.LibeyUser.Insert
{
    public class InsertLibeyUserCommandHandler : IRequestHandler<InsertLibeyUserCommand, ResponseModel>
    {
        private readonly ILibeyUserRepository libeyUserRepository;
        public InsertLibeyUserCommandHandler(ILibeyUserRepository libeyUserRepository)
        {
            this.libeyUserRepository = libeyUserRepository;
        }
        public async Task<ResponseModel> Handle(InsertLibeyUserCommand request, CancellationToken cancellationToken)
        {
            await libeyUserRepository.Insert(new LibeyUserModel(request.DocumentNumber, request.DocumentTypeId, request.Name, request.FathersLastName, request.MothersLastName, request.Address, request.UbigeoCode, request.Phone, request.Email, request.Password));
            return new ResponseModel("Se registró el usuario con éxito");
        }
    }
}
