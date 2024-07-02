using AutoRepairShop.Entities.Interfaces;

namespace AutoRepairShop.Entities;

public class Employee : ISoftRemovableEntity
{
    /// <summary>
    /// Уникальный идентификатор
    /// </summary>
    public Guid UUID { get; set; }

    /// <summary>
    /// Имя сотрудника
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Фамилия сотрудника
    /// </summary>
    public string Surname { get; set; }

    /// <summary>
    /// Отчество сотрудника
    /// </summary>
    public string Patronymic { get; set; }

    /// <summary>
    /// Ссылка на смену
    /// </summary>
    public Guid ShiftUUID { get; set; }

    /// <summary>
    /// Рабочая смена сотрудника
    /// </summary>
    public Shift Shift { get; set; }

    /// <summary>
    /// Дата поступления на работу
    /// </summary>
    public DateTime EnrollmentDate { get; set; }

    /// <summary>
    /// Дата увольнения
    /// </summary>
    public DateTime? DismissalDate { get; set; }

    /// <summary>
    /// Пометка об удалении
    /// </summary>
    public bool Removed { get; set; }
}
