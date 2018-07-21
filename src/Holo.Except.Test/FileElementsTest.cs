using System;
using System.IO;
using Xunit;

namespace Holo.Except.Test
{
    public class FileElementsTest
    {
        [Fact]
        public void LoadEmptyListFromEmptyFile()
        {
            var elements = new FileElements(new StringReader(string.Empty));
            Assert.Empty(elements);
        }

        [Fact]
        public void LoadListOfElementFromFile()
        {
            var text = "aaa" + Environment.NewLine + "bbb" + Environment.NewLine + "ccc" + Environment.NewLine + "fff";
            var elements = new FileElements(new StringReader(text));
            Assert.Equal(new string[] { "aaa", "bbb", "ccc", "fff"}, elements);
        }
    }
}
