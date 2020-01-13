using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behavior
{
    class DarkKnight: CombatStance
    {
        public override void SwitchTo()
        {
            Console.WriteLine("Защита повышена, сложнее сбить с ног, атаки ослабли. Скорость замедлена. Сильные блоки. ");
        }

    }
}
