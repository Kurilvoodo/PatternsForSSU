using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behavior
{
    class Inquisitor:CombatStance
    {
        public override void SwitchTo()
        {
            Console.WriteLine("Двойной меч, повышена скорость атаки, уменьшена защита, на расстоянии бьет молнией.");
        }
    }
}
