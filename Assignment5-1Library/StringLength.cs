using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_1Library
{
    public delegate int lengthOfstring(string s);
    public class StringLength
    {
        public int Findlength(string s)
        {
            return s.Length;
        }  
    }
}
