using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Yo no puedo volar :(");
        }
    }
}
