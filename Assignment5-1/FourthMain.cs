using Assignment5_1Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_1
{
    internal class FourthMain:EventArgs
    {
        public static event FirstIndexUpperCase UpperCase;
        static void Main(string[] args)
        {
            Console.WriteLine("enter your String To Convert First Index Into UpperCase:");
            string z = Console.ReadLine();

            StringFirstLetterUpperCase s = new StringFirstLetterUpperCase();

            FirstIndexUpperCase F = new FirstIndexUpperCase(s.FirstLetterUpperCase);

            UpperCase += F;

            string result = UpperCase(z);

            Console.WriteLine(result);

            Console.ReadLine();
        }


    }
}
