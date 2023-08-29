using LibeyTechnicalTest.Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Domain.Repositories
{
    public interface IDocumentTypeRepository
    {
        Task<IEnumerable<DocumentTypeModel>> Get();
    }
}
