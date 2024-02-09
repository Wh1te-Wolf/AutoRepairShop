using AutoRepairShop.Entities;
using AutoRepairShop.Repository;
using AutoRepairShop.Repository.Interfaces;
using AutoRepairShop.Services.Interfaces;

namespace AutoRepairShop.Services
{
    public class AcceptanceDocumentService : IAcceptanceDocumentService
    {
        private readonly IAcceptanceDocumentRepository _acceptanceDocumentRepository;

        public AcceptanceDocumentService(IAcceptanceDocumentRepository acceptanceDocumentRepository)
        {
            _acceptanceDocumentRepository = acceptanceDocumentRepository;
        }

        public AcceptanceDocument Add(AcceptanceDocument entity)
        {
            return _acceptanceDocumentRepository.Add(entity);
        }

        public void Delete(Guid uuid)
        {
            _acceptanceDocumentRepository.Delete(uuid);
        }

        public IReadOnlyCollection<AcceptanceDocument> GetAll()
        {
            return _acceptanceDocumentRepository.GetAll();
        }

        public AcceptanceDocument GetById(Guid uuid)
        {
            return _acceptanceDocumentRepository.GetById(uuid);
        }

        public AcceptanceDocument Update(AcceptanceDocument entity)
        {
            return _acceptanceDocumentRepository.Update(entity);
        }
    }
}
