using AutoMapper;
using AutoRepairShop.DTO;
using AutoRepairShop.Entities;
using AutoRepairShop.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutoRepairShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        [HttpGet(nameof(Get))]
        public async Task<IActionResult> Get()
        {
            IReadOnlyCollection<Customer> result = await _customerService.GetAllAsync();
            IEnumerable<CustomerDTO> resultDTO = _mapper.Map<IEnumerable<CustomerDTO>>(result);
            return Ok(resultDTO);
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(Guid uuid)
        {
            Customer result = await _customerService.GetByIdAsync(uuid);
            CustomerDTO resultDTO = _mapper.Map<CustomerDTO>(result);
            return Ok(resultDTO);
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(CustomerDTO customerDTO)
        {
            Customer customer = _mapper.Map<Customer>(customerDTO);
            Customer result = await _customerService.AddAsync(customer);
            CustomerDTO resultDTO = _mapper.Map<CustomerDTO>(result);
            return Ok(resultDTO);
        }

        [HttpPatch(nameof(Update))]
        public async Task<IActionResult> Update(CustomerDTO customerDTO)
        {
            Customer customer = _mapper.Map<Customer>(customerDTO);
            Customer result = await _customerService.UpdateAsync(customer);
            CustomerDTO resultDTO = _mapper.Map<CustomerDTO>(result);
            return Ok(resultDTO);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<IActionResult> Delete(Guid uuid)
        {
            await _customerService.DeleteAsync(uuid);
            return Ok();
        }
    }
}
