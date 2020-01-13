using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory.Shell;
using AbstractFactory.Factory.Core;

namespace AbstractFactory.Factory.Factory
{
    class LMGFactory : AFactory
    {
        public override AbstractShell CreateShell()
        {
            Console.WriteLine("Creating LMGShell...");
            return new LMGShell();
        }
        public override AbstractCore CreateCore()
        {
            Console.WriteLine("Creating LMGCore...");
            return new LMGCore();
        }
    }
}
