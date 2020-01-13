using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Humanoid
{
    public class Argonian :IHumanoid
    {
        public string Name { get; set; }
        public Argonian(string Name)
        {
            this.Name = Name;
        }
        public void Say()
        {
            Console.WriteLine("Опять дроиды бездельничают.");
        }
        public void Order ()
        {
            Console.WriteLine("Проверь резервный канал голосвязи!");
        }


    }
}
