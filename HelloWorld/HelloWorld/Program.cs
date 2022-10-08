using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Something else!");

            Console.WriteLine("It's" + " Easy");

            Console.WriteLine("Bread is ready.");
            Console.WriteLine("Who is the bread for?");
            string name = Console.ReadLine();
            Console.WriteLine("Noted. " + name + " got bread.");
        }
    }
}
