
namespace AutoRepairShop.DTO;

public class AcceptanceDocumentDTO
{
    public Guid UUID { get; set; }
  
    public long Number { get; set; }

    public DateTime StartTime { get; set; }
 
    public Guid? CarUUID { get; set; }
  
    public CarDTO? Car { get; set; }
  
    public Guid? CustomerUUID { get; set; }
   
    public CustomerDTO? Customer { get; set; }
   
    public string Comment { get; set; }

    public List<DocumentLineDTO> DocumentString { get; set; }
}
