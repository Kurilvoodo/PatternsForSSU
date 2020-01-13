using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Ships
{
    class DestroyerShip: AbstractShips
    {
        public DestroyerShip()
        {
            deck = 4;
        }

        public override void Build(double number1, double number2)
        {
            Console.WriteLine("Построен корабль класса разрушитель с {0} палубами; серия: {1}  ID: {2}",
                deck , number1, number2);
        }
    }
}
