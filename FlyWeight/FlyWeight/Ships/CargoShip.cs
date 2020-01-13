using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Ships
{
    class CargoShip:AbstractShips
    {
        public CargoShip()
        {
            deck = 2;
        }

        public override void Build(double number1, double number2)
        {
            Console.WriteLine("Построен грузовой корабль с {0} палубами; серия: {1} ID: {2}",
                deck, number1, number2);
        }
    }
}
