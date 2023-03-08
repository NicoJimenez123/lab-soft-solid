# SOLID

# Liskov Sustitution Principle

Supongamos que tenemos una clase abstracta llamada `Bird` que hace que un ave vuele.

```csharp
public abstract class Bird
{
    public void Eat()
    {
        Console.WriteLine("Estoy comiendo!!");
    }
    public abstract void Fly();
}
```

Y de ella hereda la clase concreta `Eagle`:
```csharp
public class Eagle : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Estoy volando muy rápido!!");
    }
}
```
Luego, queremos modelar un Pingüino:

```csharp
public class Penguin : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Yo no puedo volar :(");
    }
}
```

En este caso, estaríamos violando el principio de sustitución de Liskov, ya que la subclase `Penguin` no puede reemplazar adecuadamente a su clase base `Bird` en términos de comportamiento esperado.

Una posible solución para respetar LSP es utilizar una clase nueva para `Penguin` sin que herede de `Bird`:

```csharp
public class Penguin
{
    public void Eat()
    {
        Console.WriteLine("Estoy comiendo!!");
    }
}
```

Otra solución es mediante interfaces, esto lo veremos en [ISP](./ISP.md).
