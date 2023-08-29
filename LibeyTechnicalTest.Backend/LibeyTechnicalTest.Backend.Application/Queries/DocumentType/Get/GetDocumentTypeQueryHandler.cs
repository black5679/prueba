using LibeyTechnicalTest.Backend.Domain.Models;
using LibeyTechnicalTest.Backend.Domain.Repositories;
using MediatR;

namespace LibeyTechnicalTest.Backend.Application.Queries.DocumentType.Get
{
    public class GetDocumentTypeQueryHandler : IRequestHandler<GetDocumentTypeQuery, IEnumerable<DocumentTypeModel>>
    {
        private readonly IDocumentTypeRepository documentTypeRepository;
        public GetDocumentTypeQueryHandler(IDocumentTypeRepository documentTypeRepository)
        {
            this.documentTypeRepository = documentTypeRepository;
        }
        public async Task<IEnumerable<DocumentTypeModel>> Handle(GetDocumentTypeQuery request, CancellationToken cancellationToken)
        {
            var response = await documentTypeRepository.Get();
            return response;
        }
    }
}
