using LibeyTechnicalTest.Backend.Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Application.Commands.LibeyUser.Delete
{
    public class DeleteLibeyUserCommand : IRequest<ResponseModel>
    {
        public required string DocumentNumber { get; set; }
    }
}
