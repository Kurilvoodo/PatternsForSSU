using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyWeight.Ships;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = 20.0;
            double number2 = 66.0;

            ShipsFactory _shipFactory = new ShipsFactory();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                AbstractShips _cargoShip = _shipFactory.GetShip("Cargo");
                if (_cargoShip != null)
                    _cargoShip.Build(number1, number2);
                number1 += 1.0;
                number2 += 1.0;
            }

            for (int i = 0; i < n; i++)
            {
                AbstractShips _destroyerShip = _shipFactory.GetShip("Destroyer");
                if (_destroyerShip != null)
                    _destroyerShip.Build( number1, number2);
                number1 += 1.0;
                number2 += 1.0;
            }

            Console.ReadLine();
        }
    }
}
