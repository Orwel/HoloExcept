using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Holo.Except
{
    public class Difference : IEnumerable<string>
    {
        private IEnumerable<string> source;
        private IEnumerable<string> except;

        public Difference(IEnumerable<string> source, IEnumerable<string> except)
        {
            this.source = source;
            this.except = except;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return source.Except(except).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}