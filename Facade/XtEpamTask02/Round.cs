using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02
{
    internal class Round
    {
        #region fileds and properties
        private double _x; //double was chosen cause of we have no lack of memory yet in this program
        private double _y;
        private double _radius;
        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        
        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    throw new Exception("Radius can't be negative");
                }

            }
        }
        #endregion

        #region Operators override
        public static Round operator ++(Round circle)
        {
            Round tmp = new Round(circle);
            tmp._radius+=1;
            return tmp;
        }
        public static Round operator --(Round circle)
        {
            Round tmp = new Round(circle);
            tmp._radius -= 1;
            return tmp;
        }
        //some other easy countable propertys of a Round class
        public double Square
        {
            get
            {
                return Math.Pow(_radius, 2) * Math.PI;
            }

        }
        public double LengthOfRing
        {
            get
            {
                return 2 * _radius * Math.PI;
            }
        }
        #endregion

        #region Counstructor Round()
        public Round()
        {
            _x = _y = 0;
            _radius = 1.0f;
        }
        public Round(double r)
        {
            _x = _y = 0;
            this._radius = r;
        }
        public Round(double x, double y, double r)
        {
            _x = x;
            _y = y;
            _radius = r;
        }
        public Round(double x, double y)
        {
            _x = x;
            _y = y;
            _radius = 1;
        }
        public Round(Round NewOne)
        {
            _x = NewOne._x;
            _y = NewOne._y;
            _radius = NewOne._radius;
        }
        #endregion


    }
}
