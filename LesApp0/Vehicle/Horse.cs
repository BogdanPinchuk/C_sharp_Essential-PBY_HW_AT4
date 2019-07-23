using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0.Vehicle
{
    /// <summary>
    /// Кінь
    /// </summary>
    class Horse : AVehicle, IVehicle
    {
        /// <summary>
        /// Їзда
        /// </summary>
        public override void Move()
        {
            if (Driver != null)
            {
                Console.WriteLine($"\n\t{Driver.FullName} їздить верхи на {Name} породи {Model}, {Color} кольору.");
            }
            else
            {
                Console.WriteLine($"\n\t{Name} {Model}, {Color} кольору не може їхати без водія.");
            }
        }
    }
}
