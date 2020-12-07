using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, Employee> objemp = new SortedList<int, Employee>();

            int key = 0;
            string ch = "yes";
            while (ch != "no")
            {
                Console.WriteLine("Enter the number of Employees");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter EmpNo: ");
                    int empNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter EmpName: ");
                    String empName = Console.ReadLine();
                    Console.Write("Enter EmpBasic: ");
                    decimal basic = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter DeptNo: ");
                    short deptNo = short.Parse(Console.ReadLine());
                    Console.WriteLine();

                    objemp.Add(++key, new Employee(empNo, empName, basic, deptNo));
                }
                Console.WriteLine("Do you want to continue(yes/no)");
                ch = Console.ReadLine();
            }
            Console.WriteLine();
            
            foreach (KeyValuePair<int, Employee> objDic in objemp)
            {
                Console.WriteLine("EmpNo - {0} | EmpName - {1} | EmpSal - {2} | DeptNo - {3} ",
                    objDic.Value.EmpNo, objDic.Value.Name, objDic.Value.Basic, objDic.Value.DeptNo);
            }
            Console.WriteLine();

            Console.WriteLine("Enter EmpNo to search Employee");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (KeyValuePair<int, Employee> objDic in objemp)
            {
                if (id == objDic.Value.EmpNo)
                {
                    Console.WriteLine("EmpNo - {0} | EmpName - {1} | EmpSal - {2} | DeptNo - {3} ",
                   objDic.Value.EmpNo, objDic.Value.Name, objDic.Value.Basic, objDic.Value.DeptNo);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Enter number of records to display");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            foreach (KeyValuePair<int, Employee> objDic in objemp)
            {
                Console.WriteLine("EmpNo - {0} | EmpName - {1} | EmpSal - {2} | DeptNo - {3} ",
                  objDic.Value.EmpNo, objDic.Value.Name, objDic.Value.Basic, objDic.Value.DeptNo);
                count++;
                if (count == n1)
                {
                    break;

                }
            }
            Console.ReadLine();
        }
    }
    public class Employee
    {

        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public short DeptNo { get; set; }

        public Employee(int EmpNo = 0, string Name = "xyz", decimal Basic = 0, short DeptNo = 0)
        {
            this.EmpNo = EmpNo;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }
    }
}

namespace Assignment5Q2
{
    class Program
    {
        static void Main2(string[] args)
        {
            Employee[] empArr = new Employee[5];
            for (int i = 0; i < empArr.Length; i++)
            {
                Console.Write("Enter EmpNo: ");
                int empNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter EmpName: ");
                String empName = Console.ReadLine();
                Console.Write("Enter EmpBasic: ");
                decimal basic = decimal.Parse(Console.ReadLine());
                Console.Write("Enter DeptNo: ");
                short deptNo = short.Parse(Console.ReadLine());
                Console.WriteLine();

                empArr[i] = new Employee(empNo, empName, basic, deptNo);
            }
            List<Employee> objEmps = new List<Employee>(empArr);

            foreach (Employee e in objEmps)
            {
                Console.WriteLine("EmpNo: " + e.EmpNo);
                Console.WriteLine("EmpName: " + e.Name);
                Console.WriteLine("Salary: " + e.Basic);
                Console.WriteLine("DeptNo: " + e.DeptNo);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {

        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public short DeptNo { get; set; }

        public Employee(int EmpNo = 0, string Name = "xyz", decimal Basic = 0, short DeptNo = 0)
        {
            this.EmpNo = EmpNo;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }
    }
}

namespace Assignment5Q3
{
    class Program
    {
        static void Main3(string[] args)
        {
            List<Employee> li = new List<Employee>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter EmpNo: ");
                int empNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter EmpName: ");
                String empName = Console.ReadLine();
                Console.Write("Enter EmpBasic: ");
                decimal basic = decimal.Parse(Console.ReadLine());
                Console.Write("Enter DeptNo: ");
                short deptNo = short.Parse(Console.ReadLine());
                Console.WriteLine();

                li.Add(new Employee(empNo, empName, basic, deptNo));
            }

            Employee[] empArr = li.ToArray();
            foreach (Employee e in empArr)
            {
                Console.WriteLine("EmpNo: " + e.EmpNo);
                Console.WriteLine("EmpName: " + e.Name);
                Console.WriteLine("Salary: " + e.Basic);
                Console.WriteLine("DeptNo: " + e.DeptNo);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {

        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public short DeptNo { get; set; }

        public Employee(int EmpNo = 0, string Name = "xyz", decimal Basic = 0, short DeptNo = 0)
        {
            this.EmpNo = EmpNo;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }
    }
}

