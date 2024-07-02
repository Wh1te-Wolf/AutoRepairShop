using AutoMapper;
using AutoRepairShop.DTO;
using AutoRepairShop.Entities;
using AutoRepairShop.Services.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoRepairShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcceptanceDocumentController : ControllerBase
    {
        private readonly IAcceptanceDocumentService _acceptanceDocumentService;

        private readonly IMapper _mapper;

        private readonly IValidator<AcceptanceDocumentDTO> _validator;

        public AcceptanceDocumentController(IAcceptanceDocumentService acceptanceDocumentService, IMapper mapper, IValidator<AcceptanceDocumentDTO> validator)
        {
            _acceptanceDocumentService = acceptanceDocumentService;
            _mapper = mapper;
            _validator = validator;
        }

        [HttpGet(nameof(Get))]
        public async Task<IActionResult> Get()
        {
            IReadOnlyCollection<AcceptanceDocument> result = await _acceptanceDocumentService.GetAllAsync();
            IEnumerable<AcceptanceDocumentDTO> resultDTO = _mapper.Map<IEnumerable<AcceptanceDocumentDTO>>(result);
            return Ok(resultDTO);
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(Guid uuid)
        {
            AcceptanceDocument result = await _acceptanceDocumentService.GetByIdAsync(uuid);
            AcceptanceDocumentDTO resultDTO = _mapper.Map<AcceptanceDocumentDTO>(result);
            return Ok(resultDTO);
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(AcceptanceDocumentDTO acceptanceDocumentDTO)
        {
            var validationResult = _validator.Validate(acceptanceDocumentDTO);
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);
            AcceptanceDocument acceptanceDocument = _mapper.Map<AcceptanceDocument>(acceptanceDocumentDTO);
            AcceptanceDocument result = await _acceptanceDocumentService.AddAsync(acceptanceDocument);
            AcceptanceDocumentDTO resultDTO = _mapper.Map<AcceptanceDocumentDTO>(result);
            return Ok(resultDTO);
        }

        [HttpPatch(nameof(Update))]
        public async Task<IActionResult> Update(AcceptanceDocumentDTO acceptanceDocumentDTO)
        {
            AcceptanceDocument acceptanceDocument = _mapper.Map<AcceptanceDocument>(acceptanceDocumentDTO);
            AcceptanceDocument result = await _acceptanceDocumentService.UpdateAsync(acceptanceDocument);
            AcceptanceDocumentDTO resultDTO = _mapper.Map<AcceptanceDocumentDTO>(result);
            return Ok(resultDTO);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<IActionResult> Delete(Guid uuid)
        {
            await _acceptanceDocumentService.DeleteAsync(uuid);
            return Ok();
        }
    }
}
