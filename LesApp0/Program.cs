using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVehicle = LesApp0.Vehicle.AVehicle;
using IVehicle = LesApp0.Vehicle.IVehicle;
using Car = LesApp0.Vehicle.Car;
using Motorcycle = LesApp0.Vehicle.Motorcycle;
using Horse = LesApp0.Vehicle.Horse;

namespace LesApp0
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // припустимо, що є власник, який має 4 транспорних засоби переміщеня,
            // із яких одне із штучним інтелектом, яке саме розвозить його дітей Tesla
            Human Bogdan = new Human()
            {
                FullName = "Bogdan Pinchuk",
                Age = 27,
                ColorOfEyes = Human.ColorOfEye.Brown,
                ColorOfHair = Human.HairColor.Black,
                Height = 185f,
                Weight = 80f,
                Nationality = "Ukrainian",
                Sex = Human.SexOfHuman.male
            };

            // маємо гараж
            AVehicle[] garage = new AVehicle[]
            {
                new Horse()
                {
                    Model = "Породистий кінь",
                    Name = "Скакун",
                    Color = ConsoleColor.DarkRed,
                    Driver = Bogdan
                },
                new Motorcycle()
                {
                    // https://auto.24tv.ua/naitsikavishi_mototsykly_sezonu_2019_roku_v_ukraini_n12041
                    Name = "Kawasaki",
                    Model = "Ninja ZX-10R KRT Replica",
                    Color = ConsoleColor.Green,
                    Driver = Bogdan
                },
                new Car()
                {
                    // https://www.mercedes-benz.ua/cars/models/gls-class/suv.html
                    Name = "Mercedes-Benz",
                    Model = "GLS AMG",
                    Color = ConsoleColor.Gray,
                    Driver = Bogdan
                },
                new Car()
                {
                    Name = "Tesla",
                    Model = "Model X",
                    Color = ConsoleColor.Red
                }
            };

            // Два варіанти реалізації
#if false
            // в даному випадку трохи запутане завдання, або не до кінця сформульоване
            // так як можна присвоїти машині власника і перевірити чи вона поїде
            // або запускати поїздку через водія, тоді втрачається смисл коли немає водія
            foreach (AVehicle i in garage)
            {
                i.Move();
                //Bogdan.MoveOn(i);
            }
#endif
#if true
            foreach (IVehicle i in garage)
            {
                //i.Move();
                Bogdan.MoveOn(i);
            }
#endif
            // можна було і не реалізовувати абстрактний клас, а для використання 
            // інтерфейсу використати реалізацію звичайного класу з його наслідуванням

            // delay
            Console.ReadKey(true);
        }
    }
}
