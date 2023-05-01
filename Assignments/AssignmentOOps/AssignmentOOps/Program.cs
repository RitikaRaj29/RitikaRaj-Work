using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOps
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Emp_Name { get; set; }

        public double Salary { get; set; }


        public double HRA { get; set; }

        public double TA { get; set; }
        public double Da { get; set; }

        public double PF { get; set; }

        public double TDS { get; set; }

        public double Net_Salary { get; set; }

        public double Gross_Salary { get; set; }



        internal class Program
        {


            static void Main(string[] args)
            {
                Employee emp = new Employee();
                Console.WriteLine("Enter emp no");
                emp.EmpNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter emp name");
                emp.Emp_Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter salary");
                emp.Salary = Convert.ToDouble(Console.ReadLine());


                if (emp.Salary < 5000)
                {
                    emp.HRA = (10 * emp.Salary) / 100;
                    emp.TA = (5 * emp.Salary) / 100;
                    emp.Da = (15 * emp.Salary) / 100;

                    emp.Gross_Salary = emp.Salary + emp.HRA + emp.TA + emp.Da;

                    Console.WriteLine("Gross Salary =" + emp.Gross_Salary);

                    emp.CalculateSalary(emp.Gross_Salary);
                    emp.Show();


                }

                else if (emp.Salary < 10000)
                {
                    emp.HRA = (15 * emp.Salary) / 100;
                    emp.TA = (10 * emp.Salary) / 100;
                    emp.Da = (20 * emp.Salary) / 100;
                    emp.Gross_Salary = emp.Salary + emp.HRA + emp.TA + emp.Da;
                    Console.WriteLine("Gross Salary =" + emp.Gross_Salary);

                    emp.CalculateSalary(emp.Gross_Salary);
                    emp.Show();
                }
                else if (emp.Salary < 15000)
                {
                    emp.HRA = (20 * emp.Salary) / 100;
                    emp.TA = (15 * emp.Salary) / 100;
                    emp.Da = (25 * emp.Salary) / 100;
                    emp.Gross_Salary = emp.Salary + emp.HRA + emp.TA + emp.Da;
                    Console.WriteLine("Gross Salary =" + emp.Gross_Salary);
                    emp.CalculateSalary(emp.Gross_Salary);
                    emp.Show();
                }
                else if (emp.Salary < 20000)
                {
                    emp.HRA = (25 * emp.Salary) / 100;
                    emp.TA = (20 * emp.Salary) / 100;
                    emp.Da = (30 * emp.Salary) / 100;
                    emp.Gross_Salary = emp.Salary + emp.HRA + emp.TA + emp.Da;
                    Console.WriteLine("Gross Salary =" + emp.Gross_Salary);

                    emp.CalculateSalary(emp.Gross_Salary);
                    emp.Show();
                }
                 else if (emp.Salary >= 20000)
                {
                    emp.HRA = (30 * emp.Salary) / 100;
                    emp.TA = (25 * emp.Salary) / 100;
                    emp.Da = (35 * emp.Salary) / 100;
                    emp.Gross_Salary = emp.Salary + emp.HRA + emp.TA + emp.Da;
                    Console.WriteLine("Gross Salary =" + emp.Gross_Salary);

                    emp.CalculateSalary(emp.Gross_Salary);
                    emp.Show();
                }

            }
        }
        public double CalculateSalary(double Gross_Salary)
        {
            double PF = 0.1 * Gross_Salary;
            double TDS = 0.18 * Gross_Salary;

            Net_Salary = Gross_Salary - (PF + TDS);

            return Net_Salary;
        }
        public void Show()
        {
            Console.WriteLine("employee no is {0}", EmpNo);
            Console.WriteLine("employee name is {0}", Emp_Name);
            Console.WriteLine("Net Salary  is {0}", Net_Salary);
        }

    }
}

