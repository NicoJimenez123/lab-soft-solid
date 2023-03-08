using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee fulltime = new FullTimeEmployee();
            fulltime.Salary = 100;

            Employee parttime = new PartTimeEmployee();
            parttime.Salary = 100;

            Console.WriteLine(fulltime.CalculateSalary());
            Console.WriteLine(parttime.CalculateSalary());
        }
    }
}
