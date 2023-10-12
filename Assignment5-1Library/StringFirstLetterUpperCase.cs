using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_1Library
{
    public delegate string FirstIndexUpperCase(string str);
    public class StringFirstLetterUpperCase
    {
        public string FirstLetterUpperCase(string str)
        {
            if (str == null)
            {
                 return ("enter valid string");
            }
            else
            {
                return char.ToUpper(str[0]) + str.Substring(1);
            }
        }
    }
}
