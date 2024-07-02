using AutoRepairShop.Entities;
using AutoRepairShop.Repository.Interfaces;
using AutoRepairShop.Services.Interfaces;

namespace AutoRepairShop.Services;

public class DocumentLineService : IDocumentLineService
{
    private readonly IDocumentLineRepository _documentLineRepository;

    public DocumentLineService(IDocumentLineRepository documentLineRepository)
    {
        _documentLineRepository = documentLineRepository;
    }

    public Task<DocumentLine> AddAsync(DocumentLine entity)
    {
        return _documentLineRepository.AddAsync(entity);
    }

    public Task DeleteAsync(Guid uuid)
    {
        return _documentLineRepository.DeleteAsync(uuid);
    }

    public Task<IReadOnlyCollection<DocumentLine>> GetAllAsync()
    {
        return _documentLineRepository.GetAllAsync();
    }

    public Task<DocumentLine> GetByIdAsync(Guid uuid)
    {
        return _documentLineRepository.GetByIdAsync(uuid);
    }

    public Task<DocumentLine> UpdateAsync(DocumentLine entity)
    {
        return _documentLineRepository.UpdateAsync(entity);
    }
}
