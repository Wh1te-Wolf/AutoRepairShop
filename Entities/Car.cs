using AutoRepairShop.Entities.Interfaces;

namespace AutoRepairShop.Entities
{
    /// <summary>
    /// Автомобиль
    /// </summary>
    public class Car : ISoftRemovableEntity
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public Guid UUID { get; set; }

        /// <summary>
        /// Название автомобиля (AUDI, BMW)
        /// </summary>
        public string Brang { get; set; }

        /// <summary>
        /// Модель автомобиля (A5, X5)
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Номерной знак
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// Пометка об удалении
        /// </summary>
        public bool Removed { get; set; }
    }
}
