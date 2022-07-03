using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_system
{
    public class Employees
    {

        protected int b_Salary=1500;
        protected int f_allowance;
        protected int m_allowance;

        public Employees()
        {
            
        }

        public virtual int Salary()
        {
            int g_salary;
            g_salary=b_Salary+f_allowance+m_allowance;
            return g_salary;
        }

        


    }
    public class Engineer:Employees
    {
        public override int Salary()
        {
            base.f_allowance = 100;
            base.m_allowance = 500;

            return base.Salary();
        }

    }
    public class Manager : Employees
    {
        public override int Salary()
        {
            base.f_allowance = 250;
            base.m_allowance = 1000;

            return base.Salary();
        }

    }



    public class Analysts : Employees
    {
        public override int Salary()
        {
            base.f_allowance = 150;
            base.m_allowance = 800;

            return base.Salary();
        }

    }




    public class SalarySlip
    {
        static void Main(string[] args)
        {
            
                int employee;



                Console.WriteLine("Please Enter Number of Employee");
                employee = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= employee; i++)
                {
                 
                   
                    Console.WriteLine("\nPlease enter designation of by " + i + " Employee");
                     String n = Console.ReadLine();


                Engineer E = new Engineer();
                    Manager M = new Manager();
                    Analysts A = new Analysts();
                    if (n == "engineer" || n == "Engineer" || n == "ENGINEER")
                    {
                        Console.WriteLine("Your total Salary is" + E.Salary());
                    }
                    else if (n == "manager" || n == "Manager" || n == "MANAGER")
                    {
                        Console.WriteLine("Your total Salary is" + M.Salary());
                    }
                    else if (n == "analysts" || n == "Analysts" || n == "ANALYSTS")
                    {
                        Console.WriteLine("Your total Salary is" + A.Salary());
                    }
                    else
                    {
                        Console.WriteLine("inValid Designation");
                    }
                }

                Console.ReadLine();

            }
        }

    }

