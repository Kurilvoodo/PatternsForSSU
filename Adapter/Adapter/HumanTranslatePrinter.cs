using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Humanoid;
namespace Adapter
{
    class HumanTranslatePrinter
    {
        public static void HumanInfoPrint (IHumanoid _unit)
        {
            Console.WriteLine("Досье юнита :");
            Console.WriteLine("Имя юнита: {0}", _unit.Name);
            Console.Write("Вид речи: ");
            _unit.Say();
            Console.Write("Поведение: ");
            _unit.Order();
            Console.WriteLine();




        }
    }
}
