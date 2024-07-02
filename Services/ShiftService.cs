using AutoRepairShop.Entities;
using AutoRepairShop.Repository.Interfaces;
using AutoRepairShop.Services.Interfaces;

namespace AutoRepairShop.Services
{
    public class ShiftService : IShiftService
    {
        private readonly IShiftRepository _shiftRepository;

        public ShiftService(IShiftRepository shiftRepository)
        {
            _shiftRepository = shiftRepository;
        }

        public Task<Shift> AddAsync(Shift entity)
        {
            return _shiftRepository.AddAsync(entity);
        }

        public Task DeleteAsync(Guid uuid)
        {
            return _shiftRepository.DeleteAsync(uuid);
        }

        public Task<IReadOnlyCollection<Shift>> GetAllAsync()
        {
            return _shiftRepository.GetAllAsync();
        }

        public Task<Shift> GetByIdAsync(Guid uuid)
        {
            return _shiftRepository.GetByIdAsync(uuid);
        }

        public Task<Shift> UpdateAsync(Shift entity)
        {
            return _shiftRepository.UpdateAsync(entity);
        }
    }
}
