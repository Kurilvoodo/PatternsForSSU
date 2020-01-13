using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Ships
{
    abstract class AbstractShips
    {
        protected int deck; // количество палуб

        public abstract void Build(double number1, double number2); //Serial number/ ID
    }
}
