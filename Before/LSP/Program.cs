using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle();
            eagle.Eat();
            eagle.Fly();

            Penguin penguin = new Penguin();
            penguin.Eat();
            penguin.Fly();
        }
    }
}
