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

        public virtual double CalculateSalary()
        {
            return this.Salary;
        }
    }
}
