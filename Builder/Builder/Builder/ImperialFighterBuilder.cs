using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class ImperialFighterBuilder:BuilderBase
    {
        public ImperialFighterBuilder() : base()
        {
        }

        public override void BuildPoliticType()
        {
            _ship.PoliticType = "Fighter";
        }

        public override void BuildHyperdrive()
        {
            _ship.Hyperdrive += " Flegoxian Type 2.3 ";
        }

        public override void BuildEngine()
        {
            _ship.Engine = "4.3 Flegoxian Uranium Core";
        }

        public override void BuildDefense()
        {
            _ship.Defense = " Vex's defence screen";
        }

        public override void BuildSize()
        {
            _ship.Size = "Middle fighter class size";
        }

       
    }
}
