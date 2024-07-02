using AutoRepairShop.Entities;
using AutoRepairShop.Repository.Interfaces;
using AutoRepairShop.Services.Interfaces;

namespace AutoRepairShop.Services;

public class AcceptanceDocumentService : IAcceptanceDocumentService
{
    private readonly IAcceptanceDocumentRepository _acceptanceDocumentRepository;

    public AcceptanceDocumentService(IAcceptanceDocumentRepository acceptanceDocumentRepository)
    {
        _acceptanceDocumentRepository = acceptanceDocumentRepository;
    }

    public Task<AcceptanceDocument> AddAsync(AcceptanceDocument entity)
    {
        return _acceptanceDocumentRepository.AddAsync(entity);
    }

    public Task DeleteAsync(Guid uuid)
    {
        return _acceptanceDocumentRepository.DeleteAsync(uuid);
    }

    public Task<IReadOnlyCollection<AcceptanceDocument>> GetAllAsync()
    {
        return _acceptanceDocumentRepository.GetAllAsync();
    }

    public Task<AcceptanceDocument> GetByIdAsync(Guid uuid)
    {
        return _acceptanceDocumentRepository.GetByIdAsync(uuid);
    }

    public Task<AcceptanceDocument> UpdateAsync(AcceptanceDocument entity)
    {
        return _acceptanceDocumentRepository.UpdateAsync(entity);
    }
}
