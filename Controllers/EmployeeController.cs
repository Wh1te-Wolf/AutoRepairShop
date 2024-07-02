using AutoMapper;
using AutoRepairShop.DTO;
using AutoRepairShop.Entities;
using AutoRepairShop.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutoRepairShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        [HttpGet(nameof(Get))]
        public async Task<IActionResult> Get()
        {
            IReadOnlyCollection<Employee> result = await _employeeService.GetAllAsync();
            IEnumerable<EmployeeDTO> resultDTO = _mapper.Map<IEnumerable<EmployeeDTO>>(result);
            return Ok(resultDTO);
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(Guid uuid)
        {
            Employee result = await _employeeService.GetByIdAsync(uuid);
            EmployeeDTO resultDTO = _mapper.Map<EmployeeDTO>(result);
            return Ok(resultDTO);
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(EmployeeDTO employeeDTO)
        {
            Employee employee = _mapper.Map<Employee>(employeeDTO);
            Employee result = await _employeeService.AddAsync(employee);
            EmployeeDTO resultDTO = _mapper.Map<EmployeeDTO>(result);
            return Ok(resultDTO);
        }

        [HttpPatch(nameof(Update))]
        public async Task<IActionResult> Update(EmployeeDTO employeeDTO)
        {
            Employee employee = _mapper.Map<Employee>(employeeDTO);
            Employee result = await _employeeService.UpdateAsync(employee);
            EmployeeDTO resultDTO = _mapper.Map<EmployeeDTO>(result);
            return Ok(resultDTO);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<IActionResult> Delete(Guid uuid)
        {
            await _employeeService.DeleteAsync(uuid);
            return Ok();
        }
    }
}
