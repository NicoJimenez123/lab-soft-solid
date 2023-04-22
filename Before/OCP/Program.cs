using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeFullTime fulltime = new EmployeeFullTime();
            fulltime.Salary = 100;

            EmployeePartTime parttime= new EmployeePartTime();
            parttime.Salary = 100;

            Console.WriteLine(fulltime.CalculateSalary());
            Console.WriteLine(parttime.CalculateSalary());
        }
    }
}
