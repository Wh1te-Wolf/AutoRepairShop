using AutoMapper;
using AutoRepairShop.DTO;
using AutoRepairShop.Entities;
using AutoRepairShop.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutoRepairShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        private readonly IMapper _mapper;

        public ServiceController(IServiceService serviceService, IMapper mapper)
        {
            _serviceService = serviceService;
            _mapper = mapper;
        }

        [HttpGet(nameof(Get))]
        public async Task<IActionResult> Get()
        {
            IReadOnlyCollection<Service> result = await _serviceService.GetAllAsync();
            IEnumerable<ServiceDTO> resultDTO = _mapper.Map<IEnumerable<ServiceDTO>>(result);
            return Ok(resultDTO);
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(Guid uuid)
        {
            Service result = await _serviceService.GetByIdAsync(uuid);
            ServiceDTO resultDTO = _mapper.Map<ServiceDTO>(result);
            return Ok(resultDTO);
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(ServiceDTO serviceDTO)
        {
            Service service = _mapper.Map<Service>(serviceDTO);
            Service result = await _serviceService.AddAsync(service);
            ServiceDTO resultDTO = _mapper.Map<ServiceDTO>(result);
            return Ok(resultDTO);
        }

        [HttpPatch(nameof(Update))]
        public async Task<IActionResult> Update(ServiceDTO serviceDTO)
        {
            Service service = _mapper.Map<Service>(serviceDTO);
            Service result = await _serviceService.UpdateAsync(service);
            ServiceDTO resultDTO = _mapper.Map<ServiceDTO>(result);
            return Ok(resultDTO);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<IActionResult> Delete(Guid uuid)
        {
            await _serviceService.DeleteAsync(uuid);
            return Ok();
        }
    }
}

