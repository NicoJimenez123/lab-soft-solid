# SOLID

# Open Close Principle

Supongamos que tenemos una clase llamada `Employee` que es responsable de calcular el sueldo de cada empleado de la organización. La clase se construye teniendo en cuenta que a todos los empleados de la organización se le decide dar un bono fijo mensual que representa el 20% de su sueldo.

```csharp
public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public double CalculateSalary()
    {
        return Salary * 1.2;
    }
}
```

Pasado el tiempo, nos indican que este bono va a variar según sea un empleado de tiempo completo (full-time) o uno a tiempo parcial (part-time).

Una posibilidad es hacer la siguiente modificación a la clase `Employee`:

```csharp
public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public char Type { get; set; }

    public double CalculateSalary()
    {
        return (this.Type == 'F') ? this.CalculateFullTimeSalary() : this.CalculatePartTimeSalary();
    }

    private double CalculateFullTimeSalary()
    {
        return Salary * 1.2;
    }
    private double CalculatePartTimeSalary()
    {
        return Salary * 1.1;
    }
}
```

Luego, nos indican que va a existir un tercer tipo de empleado que es eventual, este empleado también va a tener un bono diferencial.
A esta altura, es bastante complejo continuar agregando condicionales para saber cómo calcular sueldos, es por ello que se decide hacer un refactor completo del código siguiendo las buenas prácticas SOLID:

```csharp
public abstract class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public abstract double CalculateSalary();
}

public class FullTimeEmployee : Employee
{
    public override double CalculateSalary()
    {
        return Salary * 1.2;
    }
}

public class PartTimeEmployee : Employee
{
    public override double CalculateSalary()
    {
        return Salary * 1.1;
    }
}
public class CasualEmployee : Employee
{
    public override double CalculateSalary()
    {
        return Salary * 1.5;
    }
}
```

De esta forma, si aparecen nuevos tipos de empleados, se creará una clase específica para ello sin tener que alterar el comportamiento del resto de las clases.
