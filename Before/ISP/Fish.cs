using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Fish : Animal
    {
        public void Eat()
        {
            Console.WriteLine("Estoy comiendo");
        }
        public void Run()
        {
            throw new NotImplementedException();
        }
        public void Swim()
        {
            Console.WriteLine("Estoy nadando");
        }
    }
}
