using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Humanoid;
using Adapter.Droid;
namespace Adapter.Adapter
{
    class HumanoidAdapter: IHumanoid
    {
        private IDroid _droid;
        public HumanoidAdapter(IDroid wildDogs)
        {
            this._droid = wildDogs;
        }
        public string Name
        {
            get
            {
                return _droid.Type;

            }
            set { }
        }
        public void Say() {
            _droid.Sighn();
        }
        public void Order ()
        {
            _droid.Action();
        }

        }
    }
