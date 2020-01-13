using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behavior
{
    class Fury: CombatStance
    {
        public override void SwitchTo()
        {
            Console.WriteLine("Взять два меча. Урон по себе увеличен, увеличена скорость атаки и натиск на противника.");

        }
    }
}
