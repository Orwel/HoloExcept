using System;
using Holo.Except.Arguments;

namespace Holo.Except
{
    class Program
    {
        static void Main(string[] args)
        {
            new Result(
                new Difference(
                    new FileElements(new SourcePath(args).Value),
                    new FileElements(new ExceptPath(args).Value)
                )
            ).Display();
        }
    }
}
