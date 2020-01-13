using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02
{
    class Ring : Round
    {
        #region Fields and properties
        private double _innerRadius;
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }

            set
            {
                if (value < Radius && value > 0)
                {
                    _innerRadius = value;
                }
                else
                {
                    throw new Exception("Error, inner Radius can't be negative or bigger than normal Radius");
                }
            }
        }

        public new double Square
        {
            get
            {
                return Math.Pow(_innerRadius, 2) * Math.PI;
            }

        }
        public double RingSquare
        {
            get 
            {
                return base.Square - Square;
            }
        }
        public new double LengthOfRing
        {
            get
            {
                return 2 * _innerRadius * Math.PI;
            }
        }
        #endregion

        #region constructors
        public Ring(double x,double y, double radius, double inner_radius) :
            base( x, y, radius)
        {
            _innerRadius = inner_radius;
        }

        public Ring() : base()
        {
            _innerRadius = 0.5;
        }
        public Ring(Round a) : base( a)
        { 
            _innerRadius = 0.5;
        }
        public Ring(Ring a) : base(a.X, a.Y, a.Radius)
        {
            _innerRadius = a._innerRadius;
        }
        #endregion
    }
}
