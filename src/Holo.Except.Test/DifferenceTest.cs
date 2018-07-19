using System;
using Xunit;

namespace Holo.Except.Test
{
    public class DifferenceTest
    {
        [Fact]
        public void DifferenceBetweenTwoListOfString()
        {
            var diff = new Difference(
                new string[] { "aaa", "bbb", "ccc", "ddd" }, 
                new string[] { "bbb", "ddd", "fff"}
            );
            Assert.Equal(new string[] { "aaa", "ccc"}, diff);
        }
    }
}