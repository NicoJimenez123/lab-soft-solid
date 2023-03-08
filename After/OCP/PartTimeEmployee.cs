using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class PartTimeEmployee : Employee
    {
        public override double CalculateSalary()
        {
            return Salary * 1.1;
        }
    }
}
