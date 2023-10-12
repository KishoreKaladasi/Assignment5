using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_1Library
{
    public delegate void LeavesApprove(int daysRequested);
    public class LeavesOfEmployee
    {
         
        public class Employee
        {
            private int leaves;

            public int Leaves
            {
                get { return leaves; }
                set { leaves = value; }
            }
            public Employee()
            {
                leaves = 10;
            }
            public void ApplyForLeave(int daysRequested)
            {
                if (daysRequested > 0 && daysRequested <= Leaves)
                {
                    Leaves -= daysRequested;
                    Console.WriteLine($"Leave approved. Balance leaves: {Leaves}");
                }
                else
                {
                    Console.WriteLine("Leave request denied or invalid number of days.");
                }

            }
        }
    }
}

