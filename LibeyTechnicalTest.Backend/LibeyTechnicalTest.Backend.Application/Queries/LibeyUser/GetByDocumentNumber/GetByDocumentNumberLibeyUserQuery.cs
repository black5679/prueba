using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Application.Queries.LibeyUser.GetByDocumentNumber
{
    public class GetByDocumentNumberLibeyUserQuery : IRequest<GetByDocumentNumberLibeyUserResponse>
    {
        public required string DocumentNumber { get; set; }
    }
}
