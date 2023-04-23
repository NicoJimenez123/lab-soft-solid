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
        private String _clientEmail;
        private String _products;
        private ISender sender;

        public Order(ISender sender)
        {
            this.sender = sender;
        }

        public void CreateOrder(String clientName, String clientEmail, String products)
        {
            this._clientName = clientName;
            this._clientEmail = clientEmail;
            this._products = products;
            //Realiza el proceso para dar de alta la Orden ...

            this.sendOrder();
        }

        public void sendOrder() 
        {
            this.sender.Send(this._clientEmail, "Compra realizada", "Gracias por su compra!");
        }
    }
}
