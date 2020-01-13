using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Humanoid;

namespace Adapter.Environment
{
    class Humanian
    {
        private static Humanian home = null;
        protected Humanian() { }
        public static Humanian  Inizialize()
        {
            if (home == null)
            {
                home = new Humanian();
            }
            return home;
            
        }
       
        List<IHumanoid> _humanoidUnits = new List<IHumanoid>();
        public void AddUnit(string name, string name2)
        {
            _humanoidUnits.Add(new Argonian(name));
            _humanoidUnits.Add(new Jedi(name2));
        }
        public void PrintUnit()
        {
            foreach (var item in _humanoidUnits)
            {
                HumanTranslatePrinter.HumanInfoPrint(item);
            }
        }

        


    }
}
