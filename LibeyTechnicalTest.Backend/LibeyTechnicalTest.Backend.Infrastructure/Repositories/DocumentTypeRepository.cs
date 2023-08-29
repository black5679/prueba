using LibeyTechnicalTest.Backend.Domain.Models;
using LibeyTechnicalTest.Backend.Domain.Repositories;
using LibeyTechnicalTest.Backend.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Infrastructure.Repositories
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly Context context;
        public DocumentTypeRepository(Context context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<DocumentTypeModel>> Get()
        {
            var documentTypes = await context.DocumentTypes.ToListAsync();
            return documentTypes;
        }
    }
}
