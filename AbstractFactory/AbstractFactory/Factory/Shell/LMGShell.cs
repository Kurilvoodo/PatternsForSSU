using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory.Core;

namespace AbstractFactory.Factory.Shell
{
    class LMGShell:AbstractShell
    {
        public override void Interact(AbstractCore core)
        {
            Console.WriteLine(GetHashCode() + " interact with " + core.GetHashCode());
        }
    }
}
