using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behavior
{
    class QuaiGon: CombatStance
    {
        public override void SwitchTo()
        {
            Console.WriteLine("Моментально сокращение дистанции, быстрые но слабые атаки, блок уменьшен, при натиске противника оглушает силой.");
        }
    }
}
