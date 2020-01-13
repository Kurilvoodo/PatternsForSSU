using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class SpaceShip
    {

        public string Engine { get; set; } //основной генератор
        public string PoliticType { get; set; } //дипломатический или боевой
        public string Hyperdrive { get; set; } // гипердвигатель
        public string Defense { get; set; } //Оборонительные экраны
        public string Size { get; set; } //размеры
        

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("Engine: {0}\n", Engine);
            sb.AppendFormat("PoliticType: {0}\n", PoliticType);
            sb.AppendFormat("Hyperdrive: {0}\n", Hyperdrive);
            sb.AppendFormat("Defense: {0}\n", Defense);
            sb.AppendFormat("Size: {0}\n", Size);
            return sb.ToString();
        }
    }
}
