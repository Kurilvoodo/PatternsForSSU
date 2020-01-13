using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Jedi
    {
        Strategy.Behavior.CombatStance _stance; //хранение типа боевой стойки.
        string _force = "light";
        public Jedi(Strategy.Behavior.CombatStance _stance)
        {
            this._stance = _stance;
        }
        public Strategy.Behavior.CombatStance Stance
        {
            get { return _stance; }
            set {  _stance = value;}
        }
        public void DoSomething()
        {
            _stance.SwitchTo(); //смена стойки и стратегии боя
        }

    }
}
