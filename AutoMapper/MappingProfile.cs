using AutoMapper;
using AutoRepairShop.DTO;
using AutoRepairShop.Entities;

namespace AutoRepairShop.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AcceptanceDocumentDTO, AcceptanceDocument>().ReverseMap();

            CreateMap<CarDTO, Car>().ReverseMap();

            CreateMap<CustomerDTO, Customer>().ReverseMap();

            CreateMap<DocumentLineDTO, DocumentLine>().ReverseMap();

            CreateMap<EmployeeDTO, Employee>().ReverseMap();

            CreateMap<ServiceDTO, Service>().ReverseMap();

            CreateMap<ShiftDTO, Shift>().ReverseMap();
        }
    }
}
