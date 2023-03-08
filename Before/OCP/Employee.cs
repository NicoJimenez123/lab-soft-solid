using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public char Type { get; set; }

        public double CalculateSalary()
        {
            return (this.Type == 'F') ? this.CalculateFullTimeSalary() : this.CalculatePartTimeSalary();
        }

        private double CalculateFullTimeSalary()
        {
            return Salary * 1.2;
        }
        private double CalculatePartTimeSalary()
        {
            return Salary * 1.1;
        }
    }
}
