using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory.Shell;
using AbstractFactory.Factory.Core;
namespace AbstractFactory.Factory.Factory
{
    class LaserFactory:AFactory
    {
        public override AbstractShell CreateShell()
        {
            Console.WriteLine("Creating LaserShell...");
            return new LaserShell();
        }
        public override AbstractCore CreateCore()
        {
            Console.WriteLine("Creating CocaColaWater...");
            return new LaserCore();
        }
    }
}
