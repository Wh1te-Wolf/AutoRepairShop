using AutoMapper;
using AutoRepairShop.DTO;
using AutoRepairShop.Entities;
using AutoRepairShop.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutoRepairShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftController : ControllerBase
    {
        private readonly IShiftService _shiftService;

        private readonly IMapper _mapper;

        public ShiftController(IShiftService shiftService, IMapper mapper)
        {
            _shiftService = shiftService;
            _mapper = mapper;
        }

        [HttpGet(nameof(Get))]
        public async Task<IActionResult> Get()
        {
            IReadOnlyCollection<Shift> result = await _shiftService.GetAllAsync();
            IEnumerable<ShiftDTO> resultDTO = _mapper.Map<IEnumerable<ShiftDTO>>(result);
            return Ok(resultDTO);
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(Guid uuid)
        {
            Shift result = await _shiftService.GetByIdAsync(uuid);
            ShiftDTO resultDTO = _mapper.Map<ShiftDTO>(result);
            return Ok(resultDTO);
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(ShiftDTO shiftDTO)
        {
            Shift shift = _mapper.Map<Shift>(shiftDTO);
            Shift result = await _shiftService.AddAsync(shift);
            ShiftDTO resultDTO = _mapper.Map<ShiftDTO>(result);
            return Ok(resultDTO);
        }

        [HttpPatch(nameof(Update))]
        public async Task<IActionResult> Update(ShiftDTO shiftDTO)
        {
            Shift shift = _mapper.Map<Shift>(shiftDTO);
            Shift result = await _shiftService.UpdateAsync(shift);
            ShiftDTO resultDTO = _mapper.Map<ShiftDTO>(result);
            return Ok(resultDTO);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<IActionResult> Delete(Guid uuid)
        {
            await _shiftService.DeleteAsync(uuid);
            return Ok();
        }
    }
}
