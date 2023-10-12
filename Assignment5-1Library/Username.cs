using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_1Library
{
    public delegate string enterusername(string s);
    public class Username
    {
        public string NameOfTheUser(string s)
        {
            return ($"HELLO {s}");
        }
    }
}
