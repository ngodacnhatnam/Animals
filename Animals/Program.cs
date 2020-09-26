using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Nigga", "Dick");
            Animal dog = new Dog("Puto", "Pussay");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
