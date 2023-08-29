using LibeyTechnicalTest.Backend.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Application.Queries.LibeyUser.GetByDocumentNumber
{
    public class GetByDocumentNumberLibeyUserQueryHandler : IRequestHandler<GetByDocumentNumberLibeyUserQuery, GetByDocumentNumberLibeyUserResponse>
    {
        private readonly ILibeyUserRepository libeyUserRepository;
        public GetByDocumentNumberLibeyUserQueryHandler(ILibeyUserRepository libeyUserRepository)
        {
            this.libeyUserRepository = libeyUserRepository;
        }
        public async Task<GetByDocumentNumberLibeyUserResponse> Handle(GetByDocumentNumberLibeyUserQuery request, CancellationToken cancellationToken)
        {
            var libeyUser = await libeyUserRepository.GetByDocumentNumber(request.DocumentNumber);
            var response = new GetByDocumentNumberLibeyUserResponse()
            {
                DocumentNumber = libeyUser.DocumentNumber,
                Active = libeyUser.Active,
                Address = libeyUser.Address,
                DocumentTypeId = libeyUser.DocumentTypeId,
                Email = libeyUser.Email,
                FathersLastName = libeyUser.FathersLastName,
                MothersLastName = libeyUser.MothersLastName,
                Name = libeyUser.Name,
                Password = libeyUser.Password,
                Phone = libeyUser.Phone
            };
            return response;
        }
    }
}
