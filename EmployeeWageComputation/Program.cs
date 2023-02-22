using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            CheckEmployee checkemployee = new CheckEmployee("Deloitte", 20, 100,200);
            checkemployee.EmployeeCheck();
            Console.ReadLine();
        }
    }
}
