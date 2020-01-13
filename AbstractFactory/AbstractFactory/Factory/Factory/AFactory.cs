using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory.Shell;
using AbstractFactory.Factory.Core;

namespace AbstractFactory.Factory.Factory
{
    abstract class AFactory
    {
        public abstract AbstractCore CreateCore();
        public abstract AbstractShell CreateShell();
    }
}
