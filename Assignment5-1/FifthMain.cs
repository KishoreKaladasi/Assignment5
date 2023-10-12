using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment5_1Library;

namespace Assignment5_1 
{
    
    internal class FifthMain:EventArgs
    {
        public static event LeavesApprove EventLeaves;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many leaves do you want :");
            int z = Convert.ToInt32(Console.ReadLine());

            LeavesOfEmployee.Employee Emp = new LeavesOfEmployee.Employee();

            LeavesApprove LA = new LeavesApprove(Emp.ApplyForLeave);

            EventLeaves += LA;

            //int result = EventLeaves(z);
            //Console.WriteLine(result); 

            EventLeaves?.Invoke(z);

            Console.ReadLine();
           
        }


    }
}
