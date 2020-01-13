using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behavior
{
    public abstract class CombatStance // is Strategy behavior for battle
    {
        //Абстрактный метод который меняет боевую стойку. 
        public abstract void SwitchTo();
    }
}
