using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVehicle = LesApp0.Vehicle.AVehicle;
using IVehicle = LesApp0.Vehicle.IVehicle;

namespace LesApp0
{
    /// <summary>
    /// Людина
    /// </summary>
    class Human
    {
        /// <summary>
        /// Стать людини
        /// </summary>
        public enum SexOfHuman
        {
            /// <summary>
            /// Чоловіча стать
            /// </summary>
            male,
            /// <summary>
            /// Жіноча стать
            /// </summary>
            female
        }
        #region References about color of eyes
        // часто інформація на різних мовах відрізняється
        // https://uk.wikipedia.org/wiki/Колір_очей
        // https://ru.wikipedia.org/wiki/Цвет_глаз
        // https://en.wikipedia.org/wiki/Eye_color 
        #endregion
        /// <summary>
        /// Колір очей
        /// </summary>
        public enum ColorOfEye
        {
            /// <summary>
            /// Бурштиновий
            /// </summary>
            Amber,
            /// <summary>
            /// Блакитний / Синій
            /// </summary>
            Blue,
            /// <summary>
            /// Карий
            /// </summary>
            Brown,
            /// <summary>
            /// Сірий
            /// </summary>
            Gray,
            /// <summary>
            /// Зелений
            /// </summary>
            Green,
            /// <summary>
            /// Горіховий / Болотний
            /// </summary>
            Hazel,
            /// <summary>
            /// Червоний / Фіолетовий
            /// </summary>
            Red,
            /// <summary>
            /// Жовтий
            /// </summary>
            Yellow,
            /// <summary>
            /// Чорний
            /// </summary>
            Black
        }
        #region References about color of hair
        // часто інформація на різних мовах відрізняється
        // https://uk.wikipedia.org/wiki/Пігментація_волосся
        // https://ru.wikipedia.org/wiki/Пигментация_волос
        // https://en.wikipedia.org/wiki/Human_hair_color
        #endregion
        public enum HairColor
        {
            /// <summary>
            /// Чорний -> Брюнет(ка)
            /// </summary>
            Black,
            /// <summary>
            /// Каштановий -> Шатен(ка)
            /// </summary>
            Brown,
            /// <summary>
            /// Білявий -> Блондин(ка)
            /// </summary>
            Blond,
            /// <summary>
            /// Червоний -> Рудий(а)
            /// </summary>
            Red,
            /// <summary>
            /// Сірий, Білий -> Сивий(а)
            /// </summary>
            Gray
        }

        /// <summary>
        /// ПІБ персони
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Стать
        /// </summary>
        public SexOfHuman Sex { get; set; }
        /// <summary>
        /// Національність
        /// </summary>
        public string Nationality { get; set; }
        /// <summary>
        /// Вік
        /// </summary>
        public byte Age { get; set; }
        /// <summary>
        /// Вага
        /// </summary>
        public float Weight { get; set; }
        /// <summary>
        /// Ріст
        /// </summary>
        public float Height { get; set; }
        /// <summary>
        /// Колір очей
        /// </summary>
        public ColorOfEye ColorOfEyes { get; set; }
        /// <summary>
        /// Колір волосся
        /// </summary>
        public HairColor ColorOfHair { get; set; }

        /// <summary>
        /// Можливість на чомусь їздити
        /// </summary>
        public void MoveOn(AVehicle vehicle)
        {
            vehicle.Move();
        }
        /// <summary>
        /// Можливість на чомусь їздити
        /// </summary>
        /// <param name="vehicle"></param>
        public void MoveOn(IVehicle vehicle)
        {
            vehicle.Move();
        }
    }
}
