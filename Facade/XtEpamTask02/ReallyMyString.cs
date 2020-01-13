using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02
{
    class ReallyMyString //yeah it's really mine :PPPP
    {
        
        private char[] text;
        #region index
        public char this[int id]
        {
            get
            {
                return text[id];
            }
            set
            {
                text[id] = value;
            }
        }
        #endregion
        #region Constructor and override operators
        public ReallyMyString(char[] str)
        {
            this.text = str;
        }
        
        public static bool operator ==(ReallyMyString string1, ReallyMyString string2)
        {
            return Enumerable.SequenceEqual(string1.text, string2.text);
        }
        public static bool operator !=(ReallyMyString string1, ReallyMyString string2)
        {
            return !Enumerable.SequenceEqual(string1.text, string2.text);
        }
        //concatenation
        public static ReallyMyString operator +(ReallyMyString string1, ReallyMyString string2)
        {
            return new ReallyMyString(string1.text.Concat(string2.text).ToArray());
        }


        public override string ToString()
        {
            return new string(text);
        }
        #endregion
        public int FindSymbol(char c) // return index of a symbol, if it was founded in string or -1 if it haven't been found
        {
            if (text.Contains(c))
            {
                return Array.IndexOf(text, c);
            }
            else
            {
                return -1;
            }
        }
        //To array of symbols and back
        #region Explicit operator
        public static explicit operator ReallyMyString(char[] c)
        {

            return new ReallyMyString(c);
        }
        public static explicit operator char[](ReallyMyString string1)
        {
            char[] c = new char[string1.text.Length];
            Array.Copy(string1.text,0, c, 0,c.Length);
            return c;
        }
        #endregion

    }
}
