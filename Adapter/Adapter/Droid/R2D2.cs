using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Droid
{
    class R2D2:IDroid
    {
        public string Type { get { return "R2D2 тип. Робот инженер. "; } }


        public void Sighn()
        {
            Console.WriteLine("Beep! Beep! Beep! Beuuueeeop!");

        }
        public void Action()
        {
            Console.WriteLine("*Открывает проверку входящих сигналов резервного канала*");
        }
    }
}
