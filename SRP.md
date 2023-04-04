# Single Responsability Principle

Supongamos que tenemos una clase llamada `Report` que es responsable de generar informes. La clase tiene varios métodos que se encargan de generar diferentes tipos de informes y enviarlos por correo electrónico.

```csharp
public class Report
{
    public void GenerateMonthlyReport()
    {
        // código para generar informe mensual
    }

    public void GenerateAnualReport()
    {
        // código para generar informe anual
    }

    public void SendByEmail(string addressee, string subject, string body)
    {
        // código para enviar correo electrónico
    }
}
```

Y lo ejecutamos de la siguiente manera:

```csharp
Report report = new Report();
report.SendByEmail("test@test.com", "Reporte mensual", report.GenerateMonthlyReport());
```

Luego, en otro caso de uso, tenemos que enviar un saludo de cumpleaños a los empleados de la organización, y para ello decidimos reutilizar el método `SendByEmail()`. En cuanto lo implementamos, notamos que deberíamos llevarnos la clase `Report` completa acarreando mucha funcionalidad que no vamos a necesitar.

Entonces, nos damos cuenta que la clase `Report` tiene dos responsabilidades diferentes: generar informes y enviar correos electrónicos. Esto va en contra del principio de responsabilidad única de SOLID, ya que una clase debería tener una sola responsabilidad.

Para solucionar este problema, podemos crear dos clases separadas: una clase para generar informes y otra clase para enviar correos electrónicos. De esta manera, cada clase tendría una sola responsabilidad.

```csharp
public class ReportBuilder
{
    public void GenerateMonthlyReport()
    {
        // código para generar informe mensual
    }

    public void GenerateAnualReport()
    {
        // código para generar informe anual
    }
}

public class EmailSender
{
    public void Send(string addressee, string subject, string body)
    {
        // código para enviar correo electrónico
    }
}
```

Ahora, podemos utilizar estas dos clases en conjunto para generar informes y enviar correos electrónicos:

```csharp
ReportBuilder reportBuilder = new ReportBuilder();
EmailSender emailSender = new EmailSender();
emailSender.SendByEmail("test@test.com", "Reporte mensual", reportBuilder.GenerateMonthlyReport());
```
Ahora, la clase `ReportBuilder` tiene una sola responsabilidad: generar informes. Y la clase `EmailSender` envía correos electrónicos. Esto hace que el código sea más fácil de entender, mantener y ampliar. Además, si necesitamos cambiar la forma en que se generan los informes o se envían los correos electrónicos, podemos hacerlo sin afectar a otras partes del software.
