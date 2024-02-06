using AutoRepairShop.Entities.Interfaces;

namespace AutoRepairShop.Entities
{
    /// <summary>
    /// Заказчик
    /// </summary>
    public class Customer : ISoftRemovableEntity
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public Guid UUID { get; set; }

        /// <summary>
        /// Имя заказчика
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия заказчика
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Список автомобилей заказчика
        /// </summary>
        List<Car> Cars { get; set; }

        /// <summary>
        /// Телефон заказчика
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Пометка об удалении
        /// </summary>
        public bool Removed { get; set; }
    }
}
