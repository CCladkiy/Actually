using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello everyone");
            GreetBlack();
            GreetWhite();
        }

        static void GreetWhite ()
        {
            Console.WriteLine("Hello white");
        }

        static void GreetBlack ()
        {
            Console.WriteLine("Hello black");
        }
    }
}
