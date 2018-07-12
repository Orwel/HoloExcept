using System;
using Xunit;

namespace Holo.Except.Test
{
    public class FooTest
    {
        [Fact]
        public void TwoMoreFiveEqualSeven()
        {
            Assert.Equal(7, new Foo().Add(2, 5));
        }
    }
}
