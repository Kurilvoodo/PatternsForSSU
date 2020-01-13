using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Ships
{
    class ShipsFactory
    {
        Dictionary<string, AbstractShips> _ships = new Dictionary<string, AbstractShips>();
        public ShipsFactory()
        {
            _ships.Add("Cargo", new CargoShip()); // Грузовой
            _ships.Add("Destroyer", new DestroyerShip()); // Класс разрушитель
        }

        public AbstractShips GetShip(string key)
        {
            if (_ships.ContainsKey(key))
                return _ships[key];
            else
                return null;
        }
    }
}
