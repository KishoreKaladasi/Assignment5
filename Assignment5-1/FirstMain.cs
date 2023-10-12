using Assignment5_1Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_1
{
    internal class FirstMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your first string to Concatination:");
            string x =Console.ReadLine();
            Console.WriteLine("enter your second string to Concatination:");
            string y = Console.ReadLine();

            ConcatingStrings c = new ConcatingStrings();    

            CombineStrings combinee =new CombineStrings(c.ConcatStrings);

            string result = combinee(x, y);
            Console.WriteLine("Concatenated string: " + result);


            Console.ReadLine();
        }
    }
}
