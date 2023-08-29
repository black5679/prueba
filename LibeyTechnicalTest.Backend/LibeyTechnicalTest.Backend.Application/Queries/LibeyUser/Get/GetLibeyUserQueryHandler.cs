using LibeyTechnicalTest.Backend.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Application.Queries.LibeyUser.Get
{
    public class GetLibeyUserQueryHandler : IRequestHandler<GetLibeyUserQuery, IEnumerable<GetLibeyUserResponse>>
    {
        private readonly ILibeyUserRepository libeyUserRepository;
        public GetLibeyUserQueryHandler(ILibeyUserRepository libeyUserRepository)
        {
            this.libeyUserRepository = libeyUserRepository;
        }
        public async Task<IEnumerable<GetLibeyUserResponse>> Handle(GetLibeyUserQuery request, CancellationToken cancellationToken)
        {
            var libeyUsers = await libeyUserRepository.Get();
            var response = libeyUsers.Select(libeyUser => new GetLibeyUserResponse
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

            });
            return response;
        }
    }
}
