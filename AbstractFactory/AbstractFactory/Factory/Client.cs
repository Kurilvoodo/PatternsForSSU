using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory.Factory;
using AbstractFactory.Factory.Core;
using AbstractFactory.Factory.Shell;

namespace AbstractFactory.Factory
{
    class Client
    {
        private AbstractCore _core;
        private AbstractShell _shell;
        public Client(AFactory factory)
        {
            _core = factory.CreateCore();
            _shell = factory.CreateShell();
        }
        public void Run()
        {
            Console.WriteLine("Begining production of weapon...");
            _shell.Interact(_core);
        }

    }
}
