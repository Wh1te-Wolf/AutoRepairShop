using AutoMapper;
using AutoRepairShop.DTO;
using AutoRepairShop.Entities;
using AutoRepairShop.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutoRepairShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentLineController : ControllerBase
    {
        private readonly IDocumentLineService _documentLineService;

        private readonly IMapper _mapper;

        public DocumentLineController(IDocumentLineService documentLineService, IMapper mapper)
        {
            _documentLineService = documentLineService;
            _mapper = mapper;
        }

        [HttpGet(nameof(Get))]
        public async Task<IActionResult> Get()
        {
            IReadOnlyCollection<DocumentLine> result = await _documentLineService.GetAllAsync();
            IEnumerable<DocumentLineDTO> resultDTO = _mapper.Map<IEnumerable<DocumentLineDTO>>(result);
            return Ok(resultDTO);
        }

        [HttpGet(nameof(GetById))]
        public async Task<IActionResult> GetById(Guid uuid)
        {
            DocumentLine result = await _documentLineService.GetByIdAsync(uuid);
            DocumentLineDTO resultDTO = _mapper.Map<DocumentLineDTO>(result);
            return Ok(resultDTO);
        }

        [HttpPost(nameof(Add))]
        public async Task<IActionResult> Add(DocumentLineDTO documentLineDTO)
        {
            DocumentLine documentLine = _mapper.Map<DocumentLine>(documentLineDTO);
            DocumentLine result = await _documentLineService.AddAsync(documentLine);
            DocumentLineDTO resultDTO = _mapper.Map<DocumentLineDTO>(result);
            return Ok(resultDTO);
        }

        [HttpPatch(nameof(Update))]
        public async Task<IActionResult> Update(DocumentLineDTO documentLineDTO)
        {
            DocumentLine documentLine = _mapper.Map<DocumentLine>(documentLineDTO);
            DocumentLine result = await _documentLineService.UpdateAsync(documentLine);
            DocumentLineDTO resultDTO = _mapper.Map<DocumentLineDTO>(result);
            return Ok(resultDTO);
        }

        [HttpDelete(nameof(Delete))]
        public async Task<IActionResult> Delete(Guid uuid)
        {
            await _documentLineService.DeleteAsync(uuid);
            return Ok();
        }
    }
}
