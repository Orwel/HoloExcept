using System;
using Holo.Except.Arguments;
using Xunit;

namespace Holo.Except.Test.Arguments
{
    public class ExceptPathTest
    {
        [Fact]
        public void RetrieveExceptPath()
        {
            Path path = new ExceptPath(new string[] { "source.txt", "except.txt" });
            Assert.Equal("except.txt", path.Value);
        }
    }
}