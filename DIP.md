# SOLID

# Dependency Inversion Principle

Dado un caso de uso llamado Generar orden de pedido se nos solicita armar un módulo capaz de generar una Orden y notificar al Cliente acerca de su generación. Esa  notificación será vía email. Entonces la clase resultante puede ser:

```csharp
public class EmailSender
{
    public void SendEmail(String addressee, String subject, String body)
    {
	    Console.WriteLine("Se envió email a " + addressee + ", con asunto " + subject + " y cuerpo " + body);
    }
}
public class Order
{
    private String _clientName;
    private String _clientEmail;
    private String _products;
    public void CreateOrder(String clientName, String clientEmail, String products)
    {
	    this._clientName = clientName;
	    this._clientEmail = clientEmail;
	    this._products= products;

        //Realiza el proceso para dar de alta la Orden ...

        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail(this._clientEmail, "Compra realizada", "Gracias por su compra!");
    }
}
```

Tiempo después, nos solicitan modificar el envío de la notificación, ya no se desea enviar por email solamente, sino que algunas notificaciones serán por WhatsApp. Aquí nos encontramos con el problema de tener que alterar el método que genera la Orden por una funcionalidad que no tiene que ver con la generación sino con la notificación (claramente estamos violando SRP) pero también DIP que establece que los módulos de alto nivel no deben depender de los módulos de bajo nivel. En lugar de eso, ambos deben depender de abstracciones.

Entonces mediante un refactor, seguimos este principio:

```csharp
public interface NotificacionSender
{
    public void SendNotification(String addressee, String subject, String body);
}
public class WhatsAppSender : NotificacionSender
{
    public void SendNotification(String addressee, String subject, String body)
    {
	    Console.WriteLine("Se envió WhatsApp a " + addressee + ", con asunto " + subject + " y cuerpo " + body);
    }
}
public class Order
{
    private String _clientName;
    private String _clientEmail;
    private String _products;
    private NotificacionSender _notificacionSender;
    public Order(NotificacionSender notificacionSender)
    {
        this._notificacionSender = notificacionSender;
    } 
    public void CreateOrder(String clientName, String clientEmail, String products)
    {
	    this._clientName = clientName;
	    this._clientEmail = clientEmail;
	    this._products= products;

        //Realiza el proceso para dar de alta la Orden ...

        this._notificacionSender.SendNotification(this._clientEmail, "Compra realizada", "Gracias por su compra!");
    }
}
```

De esta manera, además de tener un código más limpio y mantenible, dejamos abierta la posibilidad de que `Order` pueda intercambiar entre distintos tipos de notificaciones en tiempo de ejecución.