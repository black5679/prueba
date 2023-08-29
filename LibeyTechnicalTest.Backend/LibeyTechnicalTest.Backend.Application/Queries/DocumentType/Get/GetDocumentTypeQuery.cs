using LibeyTechnicalTest.Backend.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Application.Queries.DocumentType.Get
{
    public class GetDocumentTypeQuery : IRequest<IEnumerable<DocumentTypeModel>>
    {
    }
}
