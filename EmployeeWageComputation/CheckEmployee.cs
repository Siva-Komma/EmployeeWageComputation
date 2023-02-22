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
        private  int Num_of_Working_Days ;
        private  int Max_Hrs_In_Month ;
        public static int Emp_Present = 1;
        private int Emp_Rate_Per_Hour;
        public static int Is_Part_Time = 2;
        public static int EmpWage = 0;
        public int TotalEmpWage = 0;
        private string Company;
        public CheckEmployee(string Company, int Emp_Rate_Per_Hour, int Num_of_Working_Days, int Max_Hrs_In_Month)
        {
            this.Company = Company;
            this.Emp_Rate_Per_Hour= Emp_Rate_Per_Hour;
            this.Num_of_Working_Days= Num_of_Working_Days;
            this.Max_Hrs_In_Month= Max_Hrs_In_Month;
        }
            
        public void EmployeeCheck()
        {
            int empHrs = 0,TotalEmpHrs = 0,totalWorkingDays=0; 

            while (TotalEmpHrs<this.Max_Hrs_In_Month && totalWorkingDays <= this.Num_of_Working_Days)
            {
                totalWorkingDays++;
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
        public string toString()
        {
            return "Total EmpWages for Company: " + this.Company + "is: " + this.TotalEmpWage;
        }
    }
}
