using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class EmailSender
    {
        public void SendByEmail(string addressee, string subject, string body)
        {
            Console.WriteLine("Se envió email a " + addressee + " mensual, con asunto " + subject + " y cuerpo " + body);
        }
    }
}
