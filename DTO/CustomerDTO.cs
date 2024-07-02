
namespace AutoRepairShop.DTO;

public class CustomerDTO
{
    public Guid UUID { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    List<CarDTO> Cars { get; set; }

    public string PhoneNumber { get; set; }
}
