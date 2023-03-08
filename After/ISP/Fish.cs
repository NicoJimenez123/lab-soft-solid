using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Fish : Animal,SeaAnimal
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
}
