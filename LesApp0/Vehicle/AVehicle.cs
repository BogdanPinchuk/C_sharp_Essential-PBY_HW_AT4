using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Human = LesApp0.Human;

namespace LesApp0.Vehicle
{
    /// <summary>
    /// Абстрактний клас: Транспорт
    /// </summary>
    abstract class AVehicle
    {
        /// <summary>
        /// Назва транспорту - Марка
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Модель транспорту
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Колір транспорту
        /// </summary>
        public ConsoleColor Color { get; set; }

        /// <summary>
        /// Водій
        /// </summary>
        public Human Driver { get; set; }

        /// <summary>
        /// Переміщення/їзда на транспорті
        /// </summary>
        public abstract void Move();

    }
}
