using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_Q1
{
    class Program
    {
        static void Main1()
        {
            Func<decimal, decimal, decimal, decimal> o1 = (p, n, r) => (p * n * r) / 100;
            Console.WriteLine("Simple Interest :" + o1(5000, 10, 8));
            Console.ReadLine();
        }
    }
}

namespace Assignment6_Q2
{
    class Program
    {
        static void Main2()
        {
            Func<int, int, bool> o2 = (a, b) => a > b;
            Console.WriteLine(o2(50, 40));
            Console.ReadLine();
        }
    }

}

namespace Assignment6_Q3
{
    class Program
    {
        static void Main3()
        {
            Employee e = new Employee();
            Func<Employee, decimal> o3 = emp => emp.getBasic(e);
            Console.WriteLine("Basic Employee salary : " + o3(e));
            Console.ReadLine();
        }
        class Employee
        {
            public decimal basic = 12000;

            public decimal getBasic(Employee emp)
            {
                return emp.basic;
            }
        }

    }
}

namespace Assignment6_Q4
{
    class Program
    {
        static void Main4()
        {
            Predicate<int> o2 = a => a % 2 == 0;
            Console.WriteLine(o2(6));
            Console.ReadLine();
        }
    }
}

namespace Assignment6_Q5
{
    class Program
    {
        static void Main()
        {
            Employee e = new Employee();
            Predicate<Employee> o5 = emp => emp.IsGreaterThan10000(e);
            Console.WriteLine("IsGreater = " + o5(e));
            Console.ReadLine();
        }
        class Employee
        {
            public decimal basic = 15000;

            public decimal getBasic(Employee emp)
            {
                return emp.basic;
            }

            public bool IsGreaterThan10000(Employee emp1)
            {
                return emp1.basic > 10000;
            }
        }

    }
}