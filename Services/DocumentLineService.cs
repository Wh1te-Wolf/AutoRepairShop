using AutoRepairShop.Entities;
using AutoRepairShop.Repository;
using AutoRepairShop.Repository.Interfaces;
using AutoRepairShop.Services.Interfaces;

namespace AutoRepairShop.Services
{
    public class DocumentLineService : IDocumentLineService
    {
        private readonly IDocumentLineRepository _documentLineRepository;

        public DocumentLineService(IDocumentLineRepository documentLineRepository)
        {
            _documentLineRepository = documentLineRepository;
        }

        public DocumentLine Add(DocumentLine entity)
        {
            return _documentLineRepository.Add(entity);
        }

        public void Delete(Guid uuid)
        {
            _documentLineRepository.Delete(uuid);
        }

        public IReadOnlyCollection<DocumentLine> GetAll()
        {
            return _documentLineRepository.GetAll();
        }

        public DocumentLine GetById(Guid uuid)
        {
            return _documentLineRepository.GetById(uuid);
        }

        public DocumentLine Update(DocumentLine entity)
        {
            return _documentLineRepository.Update(entity);
        }
    }
}
