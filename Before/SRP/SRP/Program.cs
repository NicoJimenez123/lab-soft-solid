﻿using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Report report = new Report();
            EmailSender email = new EmailSender();
            email.SendByEmail("test@test.com", "Reporte mensual", report.GenerateMonthlyReport());
        }
    }
}
