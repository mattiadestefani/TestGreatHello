using System;
using TestGreatHello.Ioc;

namespace TestGreatHello
{
    class Program
    {
        static void Main(string[] args)
        {
            var greet = Container.GetService<IGreetHello>();
            Console.WriteLine(greet.GreetHello(args));
        }
    }
}
