using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class EmailSender : NotificacionSender
    {
        public void SendNotification(String addressee, String subject, String body)
        {
            Console.WriteLine("Se envió email a " + addressee + ", con asunto " + subject + " y cuerpo " + body);
        }
    }
}
