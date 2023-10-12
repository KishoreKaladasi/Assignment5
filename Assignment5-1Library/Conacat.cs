using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_1Library
{
    public delegate string CombineStrings(string s1, string s2);
    public class ConcatingStrings
    {
        public string ConcatStrings(string s1, string s2)
        {
            return (s1 + s2);
        }

     
    }
}
