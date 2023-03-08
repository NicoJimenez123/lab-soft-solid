using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Cat : Animal
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
}
