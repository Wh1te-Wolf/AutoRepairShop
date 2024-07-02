
namespace AutoRepairShop.DTO;

public class DocumentLineDTO
{
    public Guid UUID { get; set; }

    public int Number { get; set; }

    public Guid ServiceUUID { get; set; }

    public ServiceDTO Service { get; set; }
}
