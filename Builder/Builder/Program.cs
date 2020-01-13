using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builder;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ImperialFighterBuilder();
            builder.BuildHyperdrive();  // гипердвигатель
            builder.BuildEngine(); //двигатель
            builder.BuildPoliticType(); // политический тип корабля 
            var ship = builder.GetShip();
            Console.WriteLine(ship);

            builder.BuildSize();
            ship = builder.GetShip();
            Console.WriteLine(ship);
        

            
            Console.WriteLine(ship);
            Console.ReadLine();

            




        }
    }
}
