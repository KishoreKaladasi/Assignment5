using System;
using Assignment5_1Library;

namespace Assignment5_1
{
    internal class SecondMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your first string to Concatination:");
            string x = Console.ReadLine();

            StringLength s = new StringLength();

            lengthOfstring L = new lengthOfstring(s.Findlength);

            int result = L(x);
            Console.WriteLine($"length of a given string is : {result }");
            Console.ReadLine();
        }
    }
}
