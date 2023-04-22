using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class EmployeeFullTime : Employee
    {
        public override double CalculateSalary()
        {
            return this.Salary * 1.2;
        }
    }
}
