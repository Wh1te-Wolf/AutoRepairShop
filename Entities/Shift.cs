using AutoRepairShop.Entities.Interfaces;

namespace AutoRepairShop.Entities;

/// <summary>
/// Смена
/// </summary>
public class Shift : ISoftRemovableEntity
{
    /// <summary>
    /// Уникальный идентификатор
    /// </summary>
    public Guid UUID { get; set; }

    /// <summary>
    /// Пометка об удалении
    /// </summary>
    public bool Removed { get; set; }

    /// <summary>
    /// Название смены
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Начало смены
    /// </summary>
    public DateTime StartTime { get; set; }

    /// <summary>
    /// Конец смены
    /// </summary>
    public DateTime EndTime { get; set; }
}
