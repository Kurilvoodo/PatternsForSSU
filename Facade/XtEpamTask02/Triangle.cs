using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02
{
    class Triangle
    {
        #region fileds and properties
        private double _a, _b, _c;
        public double A
        {
            get
            {
                return _a;
            }
            set
            {
                if (value > 0)
                {
                    _a = value;
                }
                else
                {
                    throw new Exception("Side of triangle can't be negative");
                }
            }
        }

        public double B
        {
            get
            {
                return _b;
            }
            set
            {
                if (value > 0)
                {
                    _b = value;
                }
                else
                {
                    throw new Exception("Side of triangle can't be negative");
                }
            }
        }
        public double C
        {
            get
            {
                return _c;
            }
            set
            {
                if (value > 0)
                {
                    _c = value;
                }
                else
                {
                    throw new Exception("Side of triangle can't be negative");
                }
            }
        }

        public double Square
        {
            get
            {
                double halfPer = (_a + _b + _c) / 2;
                return Math.Sqrt(halfPer * (halfPer - _a) * (halfPer - _b) * (halfPer - _c));
            }
        }
        public double Perimetr
        {
            get
            {
                return _a + _b + _c;
            }
        }
        #endregion
        #region Constructor
        public Triangle()
        {
            //perfect triangle
            _a = 3; 
            _b = 4;
            _c = 5;
        }
        
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("Sides of triangle can't be negative");
            }
            else if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new Exception("Sides of triangle can't be negative or disbalanced like a+b>c or a+c>b and etc.");
            }
            else
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }
        }
        #endregion
    }
}
