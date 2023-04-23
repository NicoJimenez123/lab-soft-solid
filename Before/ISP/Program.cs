using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();

            Fish fish = new Fish();
            fish.Swim();
        }
    }
}
