using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Humanoid
{
    class Jedi:IHumanoid
    {
        public string Name { get; set; }
        public Jedi (string Name)
        {
            this.Name = Name;
        }
        public void Say()
        {
            Console.WriteLine("Да прибудет с вами сила!");
        }
        public void Order()
        {
            Console.WriteLine("Эскадрилия теней на вылет!");
        }

    }
}


