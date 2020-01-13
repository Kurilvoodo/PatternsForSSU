using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Droid
{
    interface IDroid
    {
        string Type{get; }
        void Sighn();
        void Action();
    }
}
