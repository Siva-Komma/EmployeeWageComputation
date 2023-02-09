using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class CheckEmployee
    {
        public static void EmployeeCheck()
        {
            int Emp_Present = 1;
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == Emp_Present)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
