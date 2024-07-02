
namespace AutoRepairShop.DTO;

public class EmployeeDTO
{
    public Guid UUID { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public string Patronymic { get; set; }

    public Guid ShiftUUID { get; set; }

    public ShiftDTO Shift { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public DateTime? DismissalDate { get; set; }
}
