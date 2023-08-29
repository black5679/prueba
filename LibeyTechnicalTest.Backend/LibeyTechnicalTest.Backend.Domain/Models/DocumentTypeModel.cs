using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Domain.Models
{
    public class DocumentTypeModel
    {
        public int DocumentTypeId { get; set; }
        public string DocumentTypeDescription { get; set; }
        public DocumentTypeModel(int documentTypeId, string documentTypeDescription)
        {
            DocumentTypeId = documentTypeId;
            DocumentTypeDescription = documentTypeDescription;
        }
    }
}
