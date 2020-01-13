using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Humanoid;
using Adapter.Droid;
using Adapter.Adapter;
using Adapter.Environment;
namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDroid _droids = new C3PO();
            HumanoidAdapter adapter = new HumanoidAdapter(_droids);
            HumanTranslatePrinter.HumanInfoPrint(adapter);
            Console.ReadLine();
            Humanian home = Humanian.Inizialize();
            home.AddUnit("Файвз", "Рядовой");
            home.PrintUnit();
            Humanian home2 = Humanian.Inizialize();
            home2.PrintUnit();
            Console.WriteLine(home.GetHashCode());
            Console.WriteLine(home2.GetHashCode());
            Droidistic droids = new Droidistic();
            droids.AddDroids();
            droids.PrintDroids();
            Console.ReadLine();
        }
    }
}
