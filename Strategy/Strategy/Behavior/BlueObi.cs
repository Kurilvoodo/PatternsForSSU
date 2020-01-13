using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Behavior
{
    class BlueObi:CombatStance
    {
        public override void SwitchTo()
        {
            Console.WriteLine("Стойка синего мечника: парирование увеличиено, увеличина скорость атаки, преимущество на высоте, особая реплика:'Ты должен был бороться со злом а не примкнуть к нему!' ") ;

        }
    }
}
