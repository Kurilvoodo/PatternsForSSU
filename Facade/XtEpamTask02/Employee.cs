using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02
{
    class Employee : User
    {
        #region fields and properties
        private int _exp; // expierienct of a job 
        private string _position; 

        public int Exp
        {
            get 
            {
                return _exp;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Expierience can't be below zero years");
                }
                else
                {
                    _exp = value;
                }
            }
        }
        public string Position
        {
            get 
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }
        #endregion
        #region Constructor
        public Employee(string surname, string name, string otch, DateTime birthday, int expierience, string post) : base(surname, name, otch, birthday)
        {
            _exp = expierience;
            _position = post;
        }
        #endregion
        #region override methods
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                String.Format("Experience: {0}" + Environment.NewLine +
                "Position at job: {1}", _exp, _position);
        }
        #endregion
    }
}
