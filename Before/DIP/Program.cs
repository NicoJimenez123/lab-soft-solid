using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            ISender emailSender = new EmailSender();
            order.CreateOrder("Juan", "juan@test.com", "Pintura,Pincel,Colorante", emailSender);
        }
    }
}
