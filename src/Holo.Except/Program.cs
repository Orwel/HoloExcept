using System;

namespace Holo.Except
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Two more five equal " + new Foo().Add(2, 5));
        }
    }
}
