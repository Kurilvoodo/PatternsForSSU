using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory.Core;

namespace AbstractFactory.Factory.Shell
{
    abstract class AbstractShell
    {
        public abstract void Interact(AbstractCore core);
    }
}
