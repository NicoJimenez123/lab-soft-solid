using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportBuilder reportBuilder = new ReportBuilder();
            EmailSender emailSender = new EmailSender();
            emailSender.SendByEmail("test@test.com", "Reporte mensual", reportBuilder.GenerateMonthlyReport());
        }
    }
}
