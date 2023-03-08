using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Order
    {
        private String _clientName;
        private String _clientContact;
        private String _products;
        private NotificacionSender _notificacionSender;
        public Order(NotificacionSender notificacionSender)
        {
            this._notificacionSender = notificacionSender;
        }
        public void CreateOrder(String clientName, String clientContact, String products)
        {
            this._clientName = clientName;
            this._clientContact = clientContact;
            this._products = products;

            //Realiza el proceso para dar de alta la Orden ...

            this._notificacionSender.SendNotification(this._clientContact, "Compra realizada", "Gracias por su compra!");
        }
    }
}
