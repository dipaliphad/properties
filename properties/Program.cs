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
            Stud s1 = new Stud();
            s1.Id = 1;
            s1.Rollno = 11;
            s1.Name = "sam";
            s1.Per = 80;
            Console.WriteLine($"Id{s1.Id}\n {s1.Rollno}\n {s1.Name}\n  {s1.Per}");
        }
    }
}
