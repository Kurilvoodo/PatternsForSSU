using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behavior
{
    class LightKnight: CombatStance
    {
        public override void SwitchTo()
        {
            Console.WriteLine("Урон уменьшен, сила вложена в меч и позволяет проводить контр атаку после успешного блока. Передвижение сильно замедленно.");

        }
    }
}
