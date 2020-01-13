using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02
{
    class User
    {
        #region fileds and properties
        private string _surname;
        private string _name;
        private string _otch;
        private DateTime _dateOfBirth;
        
        
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Otch
        {
            get
            {
                return _otch;
            }
            set 
            {
                _otch = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value < DateTime.Now)
                {
                    _dateOfBirth = value;
                }
                else
                {
                    throw new Exception("Date of Birth can't be further than today");
                }
                
            }
        }

        public int Age
        {
            get 
            {
                return (int)DateTime.Now.Subtract(_dateOfBirth).TotalDays / 365;
            }
        }
        #endregion

        #region Constructors
        public User()
        {
            _surname = "";
            _name = "";
            _dateOfBirth = DateTime.Today;
            
        }
        public User(string surname, string name,string otch, DateTime birthday)
        {
            this._surname = surname;
            this._name = name;
            this._otch = otch;
             this._dateOfBirth = birthday;
        }
        #endregion

        public override string ToString()
        {
            return String.Format("Name: {0}" + Environment.NewLine +
                "Surname: {1}" + Environment.NewLine +
                "Otch: {2}" + Environment.NewLine +
                "Date of Birth: {3}" + Environment.NewLine +
                "Age: {4}", _name, _surname, _otch, _dateOfBirth, Age);
        }
    }
}
