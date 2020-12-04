using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Q3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter how many student want");
            int size = Convert.ToInt32(Console.ReadLine());
           Student[] s = new Student[size];
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Enter Student roll no");
                int no = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student name");
                string name = Console.ReadLine();
                
                Console.WriteLine("Enter Student mark");
                decimal mark = Convert.ToDecimal(Console.ReadLine());
                Student s1 = new Student(no, name, mark);
                s[i] = s1;
            }
            foreach (Student a in s)
            {
                Console.WriteLine(a.RollNo + " " + a.Name + " " + a.Mark);
            }
        }
    }
    public struct Student
    {
        string name;
        private int rollno;
        decimal marks;
        
        public string Name
        {
            set
            {

                if (value != null)
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("name not be null");
                }
            }
            get
            {
                return name;
            }
        }
        public int RollNo
        {
            set
            {
                if (value > 0)
                {
                    this.rollno = value;
                }

            }
            get
            {
                return this.rollno;
            }
        }
        public decimal Mark
        {
            set
            {
                if (value > 0)
                {
                    this.marks = value;
                }
            }
            get
            {
                return marks;
            }
        }
        public Student(int roll, string name, decimal mark)
        {

            

            this.rollno = roll;
            this.name = name;
            this.marks = mark;
        }
    }
}
