using AutoRepairShop.Entities.Interfaces;

namespace AutoRepairShop.Entities
{
    /// <summary>
    /// Документ приёмки
    /// </summary>
    public class AcceptanceDocument : IEntity
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public Guid UUID { get; set; }

        /// <summary>
        /// Порядковый номер документа приёмки
        /// </summary>
        public long Number { get; set; }

        /// <summary>
        /// Дата приёмки документа
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Ссылка на автомобиль
        /// </summary>
        public Guid CarUUID { get; set; }

        /// <summary>
        /// Автомобиль
        /// </summary>
        public Car Car { get; set; }

        /// <summary>
        /// Ссылка на заказчика
        /// </summary>
        public Guid CustomerUUID { get; set; }

        /// <summary>
        /// Заказчик
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Комментарий по документу
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// строки оказываемых услуг
        /// </summary>
        public List<DocumentLine> DocumentString { get; set; }
    }
}
