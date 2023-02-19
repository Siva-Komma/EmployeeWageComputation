using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EmployeeWageComputation
{
    class CheckEmployee
    {
       // public const int Num_of_Working_Days = 20;
       // public const int Max_Hrs_In_Month = 100;
        public void EmployeeCheck(string Company,int Num_of_Working_Days,int Max_Hrs_In_Month)
        {
            int Emp_Present = 1;
            int Emp_Rate_Per_Hour=20;
            int Is_Part_Time = 2;
            int empHrs = 0;
            int EmpWage = 0;
            int TotalEmpWage = 0;
            int TotalEmpHrs = 0;


            while(TotalEmpHrs<Max_Hrs_In_Month && Num_of_Working_Days <= Num_of_Working_Days)
            {
                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case 0:
                        empHrs = 8;
                        break;
                    case 1:
                        empHrs = 4;
                        break;
                    case 2:
                        empHrs = 0;
                        break;
                }
                EmpWage = Emp_Rate_Per_Hour * empHrs;
                TotalEmpWage += EmpWage;
                TotalEmpHrs += empHrs;
                Console.WriteLine("Emp Hrs: " + TotalEmpHrs);
                Console.WriteLine("Emp Wage: " + EmpWage);
            }
            TotalEmpWage = TotalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Comapany: {0} Number of working days: {1} Max working Hours: {2} Toayal Emp Wage: {3} " ,Company,Num_of_Working_Days, Max_Hrs_In_Month, TotalEmpWage);
        }
    }
}
