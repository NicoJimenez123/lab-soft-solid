using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee fulltime = new Employee();
            fulltime.Salary = 100;
            fulltime.Type = 'F';

            Employee parttime= new Employee();
            parttime.Salary = 100;
            parttime.Type = 'P';

            Console.WriteLine(fulltime.CalculateSalary());
            Console.WriteLine(parttime.CalculateSalary());
        }
    }
}
