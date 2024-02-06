﻿using AutoRepairShop.Entities.Interfaces;

namespace AutoRepairShop.Entities
{
    /// <summary>
    /// Строка документа
    /// </summary>
    public class DocumentLine : IEntity
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public Guid UUID { get; set; }

        /// <summary>
        /// Порядковый номер строки
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Ссылка науслугу
        /// </summary>
        public Guid ServiceUUID { get; set; }

        /// <summary>
        /// Услуга
        /// </summary>
        public Service Service { get; set; }
    }
}