using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public interface NotificacionSender
    {
        public void SendNotification(String addressee, String subject, String body);
    }
}
