using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Droid;
using Adapter.Adapter;

namespace Adapter.Environment
{
    class Droidistic
    {
        List<IDroid> _droids = new List<IDroid>();
        private HumanoidAdapter adapter;
        public void AddDroids()
        {
            _droids.Add(new R2D2());
            _droids.Add(new C3PO());
        }
        public void PrintDroids()
        {
            foreach (var item in _droids)
            {
                adapter = new HumanoidAdapter(item);
                HumanTranslatePrinter.HumanInfoPrint(adapter);
            }
        }
    }
}
