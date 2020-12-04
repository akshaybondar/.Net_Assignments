using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter How many Employee Details do you want to Enter");
            x = Convert.ToInt32(Console.ReadLine());
            Employee [] o = new Employee[x];
            for(int i = 0; i < x; i++) 
            {
                string n;
                decimal s;
                Console.WriteLine("Enter Employee Name :  ");
                n = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Salary : ");
                s = Convert.ToDecimal(Console.ReadLine());
                o[i] = new Employee(n, s);
            }
            decimal d=0;
            foreach (Employee item in o)
            {

                if (d < item.Salary)
                    d = item.Salary;
            }
            Console.WriteLine("Highest Salary of employee Details");
            foreach (Employee item in o)
            {
                
                if (d == item.Salary)
                {
                    
                    item.DisplayDetails();
                }
            }
            Console.WriteLine("Enter Employee ID to be search Details");
            x = Convert.ToInt32(Console.ReadLine());
            foreach (Employee item in o)
            {

                if (x == item.EmpNo)
                {

                    item.DisplayDetails();
                }
            }
        }
    }
    public class Employee
    {
        private string name;
        private int empno;
        private decimal salary;
        private static int auto;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                    name = value;
                else
                    Console.WriteLine("Name should be not null");
            }
        }
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value != 0)
                    salary = value;
                else
                    Console.WriteLine("Salary should be not null");
            }
        }
        public int EmpNo
        {
            get
            {
                return empno;
            }
            set
            {
                empno = value;
            }
        }
        public Employee(string name,decimal salary)
        {
            auto++;
            this.EmpNo = auto;
            this.Name = name;
            this.Salary = salary;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID      :   {0} " ,EmpNo);
            Console.WriteLine();
            Console.WriteLine("Employee Name    :   {0}" ,Name);
            Console.WriteLine();
            Console.WriteLine("Employee Salary  :   {0}", Salary);
            Console.WriteLine();
        }


    }


}
