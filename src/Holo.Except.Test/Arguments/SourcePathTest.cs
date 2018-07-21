using System;
using Holo.Except.Arguments;
using Xunit;

namespace Holo.Except.Test.Arguments
{
    public class SourcePathTest
    {
        [Fact]
        public void RetrieveSourcePath()
        {
            Path path = new SourcePath(new string[] { "source.txt", "except.txt" });
            Assert.Equal("source.txt", path.Value);
        }
    }
}