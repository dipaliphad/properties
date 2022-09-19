using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Circle c1 = new Circle(3);
            //c1.Area();
            //Console.WriteLine(c1);
            Rectangle r1 = new Rectangle(6,3);
            r1.Area();
            Console.WriteLine(r1);

            //method of overloading:
            //Calculation c1= new Calculation();
            //Console.WriteLine(c1.Subtraction(70,40,10));
            //Console.WriteLine(c1.Subtraction(80,40.5));
            //Console.WriteLine(c1.Subtraction(100,50));


            ////object initializer stntax
            //Stud s2 = new Stud { Id = 2, Rollno = 12, Name = "dipu", Per = 85 };
            //Console.WriteLine($"  second stud detail:\n Id{s2.Id}\n {s2.Rollno}\n {s2.Name}\n {s2.Per}");

            //Stud s1 = new Stud();
            //s1.Id = 1;
            //s1.Rollno = 11;
            //s1.Name = "sam";
            //s1.Per = 80;
            //Console.WriteLine($" first student details:\n Id{s1.Id}\n {s1.Rollno}\n {s1.Name}\n {s1.Per}");
        }
    }
}
