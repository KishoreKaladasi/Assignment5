using Assignment5_1Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_1
{
    internal class ThirdMain:EventArgs
    {
        public static event enterusername UserName;
        static void Main(string[] args)
        {
            Console.WriteLine("enter your Name:");
            string x = Console.ReadLine();

            Username u = new Username();

            enterusername Greet = new enterusername(u.NameOfTheUser);
 
            UserName += Greet;

            string name = UserName(x);

            Console.Write(name);
            Console.ReadLine();



        }
    }
}
