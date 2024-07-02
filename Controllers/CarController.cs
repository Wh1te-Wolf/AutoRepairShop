using AutoMapper;
using AutoRepairShop.DTO;
using AutoRepairShop.Entities;
using AutoRepairShop.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutoRepairShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        private readonly IMapper _mapper;

        public CarController(ICarService carService, IMapper mapper)
        {
            _carService = carService;
            _mapper = mapper;
        }

        [HttpGet(nameof(Get))]
        public async Task<IActionResult> Get()
        {
            IReadOnlyCollection<Car> result = await _carService.GetAllAsync();
            IEnumerable<CarDTO> resultDTO = _mapper.Map<IEnumerable<CarDTO>>(result);
            return Ok(resultDTO);
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(Guid uuid)
        {
            Car result = await _carService.GetByIdAsync(uuid);
            CarDTO resultDTO = _mapper.Map<CarDTO>(result);
            return Ok(resultDTO);
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(CarDTO carDTO)
        {
            Car car = _mapper.Map<Car>(carDTO);
            Car result = await _carService.AddAsync(car);
            AcceptanceDocumentDTO resultDTO = _mapper.Map<AcceptanceDocumentDTO>(result);
            return Ok(resultDTO);
        }

        [HttpPatch(nameof(Update))]
        public async Task<IActionResult> Update(CarDTO carDTO)
        {
            Car car = _mapper.Map<Car>(carDTO);
            Car result = await _carService.UpdateAsync(car);
            CarDTO resultDTO = _mapper.Map<CarDTO>(result);
            return Ok(resultDTO);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<IActionResult> Delete(Guid uuid)
        {
            await _carService.DeleteAsync(uuid);
            return Ok();
        }
    }
}
