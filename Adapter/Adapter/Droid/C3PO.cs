using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Droid
{
    class C3PO:IDroid
    {
        public string Type { get { return "C3PO робот секретарь."; } }
        public void Sighn ()
        {
            Console.WriteLine("Здравствуйте, я C3PO робот секретарь и переводчик!");

        }
        public void Action ()
        {
            Console.WriteLine("Я могу лишь предложить вам функции переводчика, R2, будь добр открой протокол проверки резервных каналов голосвязи!");
        }
    }
}
