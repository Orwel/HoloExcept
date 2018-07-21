using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Holo.Except
{
    public class FileElements : IEnumerable<string>
    {
        public TextReader file;

        public FileElements(TextReader file)
        {
            this.file = file;
        }

        public FileElements(StreamReader file) :
            this((TextReader)file)
        { }

        public FileElements(string path) :
            this(new StreamReader(path))
        { }

        public IEnumerator<string> GetEnumerator()
        {
            var elements = new List<string>();
            string line;
            while((line=file.ReadLine())!=null)
            {
                elements.Add(line);
            }
            return elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}