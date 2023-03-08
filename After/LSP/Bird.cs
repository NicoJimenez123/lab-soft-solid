using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public abstract class Bird
    {
        public void Eat()
        {
            Console.WriteLine("Estoy comiendo!!");
        }
        public abstract void Fly();
    }
}
