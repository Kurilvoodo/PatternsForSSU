using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class RepublicPeaceBuilder:BuilderBase
    {
        public RepublicPeaceBuilder()
            : base()
        {
        }

        public override void BuildPoliticType()
        {
            _ship.PoliticType = "Diplomatic code";
        }

        public override void BuildHyperdrive()
        {
            _ship.Hyperdrive += " Kamino's industrial Type 1.8 ";
        }

        public override void BuildEngine()
        {
            _ship.Engine = "2.5 Kamino's Vendeled core ";
        }

        public override void BuildDefense()
        {
            _ship.Defense = " Argonian's defence screen";
        }

        public override void BuildSize()
        {
            _ship.Size = "Big cargo luxury size";
        }
    }
}
