namespace AutoRepairShop.DTO;

public class ShiftDTO
{
    public Guid UUID { get; set; }

    public string Name { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }
}
