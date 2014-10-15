using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLab
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolAbstractFactory factory = new NackademinFactory();
            int edu = factory.CreateEducation().NumberOfStudents;
            Console.WriteLine(edu);
            Console.ReadLine();
        }
    }
}
