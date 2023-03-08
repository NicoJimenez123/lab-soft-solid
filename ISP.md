# SOLID

# Interface Segregation Principle

Tenemos que modelizar dos especies de animales: Perro y Gato. Ambos tienen la capacidad de correr y comer. Ya que todos ellos son animales, armamos una interfaz `Animal` de forma tal de contener su contrato:
```csharp
public interface Animal
{
    public void Eat();
    public void Run();
}
```

E implementamos la interfaz en ambas clases:
```csharp
public class Dog : Animal
{
    public void Eat()
    {
        Console.WriteLine("Estoy comiendo");
    }
    public void Run()
    {
        Console.WriteLine("Soy un perro y estoy corriendo");
    }
}
public class Cat : Animal
{
    public void Eat()
    {
        Console.WriteLine("Estoy comiendo");
    }
    public override void Run()
    {
        Console.WriteLine("Soy un gato y estoy corriendo");
    }
}
```
Luego, nos solicitan modelar un pez (sabe nadar y comer). Entonces decidimos modificar la interfaz `Animal` para poder representar la nueva acción de nadar:
```csharp
public interface Animal
{
    public void Eat();
    public void Run();
    public void Swim();
}
```
```csharp
public class Dog : Animal
{
    public void Eat()
    {
        Console.WriteLine("Estoy comiendo");
    }
    public void Run()
    {
        Console.WriteLine("Soy un perro y estoy corriendo");
    }
    public void Swim()
    {
        throw new NotImplementedException();
    }
}
public class Cat : Animal
{
    public void Eat()
    {
        Console.WriteLine("Estoy comiendo");
    }
    public override void Run()
    {
        Console.WriteLine("Soy un gato y estoy corriendo");
    }
    public void Swim()
    {
        throw new NotImplementedException();
    }
}
public class Fish : Animal
{
    public void Eat()
    {
        Console.WriteLine("Estoy comiendo");
    }
    public override void Run()
    {
        throw new NotImplementedException();
    }
    public void Swim()
    {
        Console.WriteLine("Estoy nadando");
    }
}
```

Notamos algo extraño, ahora tenemos clases que implementan de forma parcial su interfaz.

Una posible solución para respetar ISP es dividir esa única interfaz `Animal` en varias según necesitemos:

```csharp
public interface Animal
{
    public void Eat();
}
public interface TerrestrialAnimal
{
    public void Run();
}
public interface SeaAnimal
{
    public void Swim();
}
```
```csharp
public class Dog : Animal,TerrestrialAnimal
{
    public void Eat()
    {
        Console.WriteLine("Estoy comiendo");
    }
    public void Run()
    {
        Console.WriteLine("Soy un perro y estoy corriendo");
    }
}
public class Cat : Animal,TerrestrialAnimal
{
    public void Eat()
    {
        Console.WriteLine("Estoy comiendo");
    }
    public override void Run()
    {
        Console.WriteLine("Soy un gato y estoy corriendo");
    }
}
public class Fiash : Animal,SeaAnimal
{
    public void Eat()
    {
        Console.WriteLine("Estoy comiendo");
    }
    public void Swim()
    {
        Console.WriteLine("Estoy nadando");
    }
}
```

Lo que se intenta es mantener siempre las interfaces lo más pequeñas posibles y asegurarse que toda clase que las implemente las utilice por completo.