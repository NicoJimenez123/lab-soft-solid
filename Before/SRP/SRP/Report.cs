using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Report
    {
        public String GenerateMonthlyReport()
        {
            Console.WriteLine("Se generó reporte mensual");
            return "<Contenido del reporte mensual>";
        }

        public String GenerateAnualReport()
        {
            Console.WriteLine("Se generó reporte anual");
            return "<Contenido del reporte anual>";
        }
    }
}
