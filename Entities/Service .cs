using AutoRepairShop.Entities.Interfaces;

namespace AutoRepairShop.Entities
{
    public class Service : ISoftRemovableEntity
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public Guid UUID { get; set; }

        /// <summary>
        /// Название услуги
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Стоимость услуги
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Пометка об удалении
        /// </summary>
        public bool Removed { get; set; }
    }
}
