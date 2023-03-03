﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EmployeeWageComputation
{
    class CheckEmployee
    {
        private  int Num_of_Working_Days ;
        private  int Max_Hrs_In_Month ;
       // public static int Emp_Present = 1;
        private int Emp_Rate_Per_Hour;
       // public static int Is_Part_Time = 2;
        public static int EmpWage = 0;
        public string company;

        public int TotalEmpWage;

        public CheckEmployee(string company, int Emp_Rate_Per_Hour, int Num_of_Working_Days, int Max_Hrs_In_Month)
        {
            this.company = company;
            this.Emp_Rate_Per_Hour= Emp_Rate_Per_Hour;
            this.Num_of_Working_Days= Num_of_Working_Days;
            this.Max_Hrs_In_Month= Max_Hrs_In_Month;
        }
        public void setTotalEmpWages(int totalEmpWage)
        {
            this.TotalEmpWage = totalEmpWage;
        }
        public string tostring()
        {
            return "Total emp wage for company: " +this.company  + "is: " + this.TotalEmpWage;
        }

        public class EmpWageBuliderArray
        {
            public const int Emp_Present = 1;
            public const int Is_Part_Time = 2;
            private int numOfCompany = 0;
            private CheckEmployee[] CheckEmpWageArray;

            public EmpWageBuliderArray()
            {
                this.CheckEmpWageArray = new CheckEmployee[5];
            }
            public void addCompanyEmpWage(string company, int Emp_Rate_Per_Hour,int Num_of_Working_Days, int Max_Hrs_In_Month)
            {
                CheckEmpWageArray[this.numOfCompany] = new CheckEmployee(company, Emp_Rate_Per_Hour, Num_of_Working_Days, Max_Hrs_In_Month);
                numOfCompany++;
            }
            public void EmployeeCheck()
            {
                for(int i=0;i<numOfCompany;i++)
                {
                    CheckEmpWageArray[i].setTotalEmpWages(this.EmployeeCheck(this.CheckEmpWageArray[i]));
                    Console.WriteLine(this.CheckEmpWageArray[i].tostring());
                }
            }
            private int EmployeeCheck(CheckEmployee checkEmployee)
            {
                int empHrs = 0, TotalEmpHrs = 0, totalWorkingDays = 0;

                while (TotalEmpHrs < checkEmployee.Max_Hrs_In_Month && totalWorkingDays <= checkEmployee.Num_of_Working_Days)
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
                    EmpWage = checkEmployee.Emp_Rate_Per_Hour * empHrs;
                    checkEmployee.TotalEmpWage += EmpWage;
                    TotalEmpHrs += empHrs;
                    //Console.WriteLine("Emp Hrs: " + TotalEmpHrs);
                    //Console.WriteLine("Emp Wage: " + EmpWage);
                }
                checkEmployee.TotalEmpWage = TotalEmpHrs * checkEmployee.Emp_Rate_Per_Hour;
                TotalEmpHrs += empHrs;
                Console.WriteLine("Comapany: {0} Number of working days: {1} Max working Hours: {2} Toayal Emp Wage: {3} ", checkEmployee.company, checkEmployee.Emp_Rate_Per_Hour, checkEmployee.Num_of_Working_Days, checkEmployee.Max_Hrs_In_Month);

                return TotalEmpHrs * checkEmployee.Emp_Rate_Per_Hour;
            }
            //public string toString()
            //{
            //    return "Total EmpWages for Company: " + this.Company + "is: " + this.TotalEmpWage;
            //}
        }
    }
}
