using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Application.Queries.LibeyUser.Get
{
    public class GetLibeyUserQuery : IRequest<IEnumerable<GetLibeyUserResponse>>
    {
    }
}
