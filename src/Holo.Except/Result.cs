using System;
using System.Collections.Generic;

namespace Holo.Except
{
    public class Result
    {
        private readonly IEnumerable<string> elements;

        public Result(IEnumerable<string> elements)
        {
            this.elements = elements;
        }

        public void Display()
        {
            foreach(var element in elements)
                Console.WriteLine(element);
        }
    }
}