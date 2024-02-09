using AutoRepairShop.Entities;
using AutoRepairShop.Repository;
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

        public Shift Add(Shift entity)
        {
            return _shiftRepository.Add(entity);
        }

        public void Delete(Guid uuid)
        {
            _shiftRepository.Delete(uuid);
        }

        public IReadOnlyCollection<Shift> GetAll()
        {
            return _shiftRepository.GetAll();
        }

        public Shift GetById(Guid uuid)
        {
            return _shiftRepository.GetById(uuid);
        }

        public Shift Update(Shift entity)
        {
            return _shiftRepository.Update(entity);
        }
    }
}
