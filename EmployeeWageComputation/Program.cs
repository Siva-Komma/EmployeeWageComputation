using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmployeeWageComputation.CheckEmployee;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            EmpWageBuliderArray checkemployee = new EmpWageBuliderArray();
            checkemployee.addCompanyEmpWage("DMart",20,3,10);
            checkemployee.addCompanyEmpWage("Reliance", 10, 4, 20);
            checkemployee.addCompanyEmpWage("Deloitte", 30, 5, 10);
            checkemployee.EmployeeCheck();
            Console.ReadLine();
        }
    }
}
