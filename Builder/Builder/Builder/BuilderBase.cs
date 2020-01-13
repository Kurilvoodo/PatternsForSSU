using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    abstract class BuilderBase
    {
        protected SpaceShip _ship;

        protected BuilderBase()
        {
            _ship = new SpaceShip();
        }

        public SpaceShip GetShip()
        {
            return _ship;
        }

        public abstract void BuildEngine();
        public abstract void BuildPoliticType();
        public abstract void BuildHyperdrive();
        
        public abstract void BuildDefense();
        public abstract void BuildSize();
        
    }
}
