namespace Holo.Except.Arguments
{
    public class ExceptPath : Path
    {
        private readonly string[] args;

        public ExceptPath(string[] args)
        {
            this.args = args;
        }

        public string Value => args[1];
    }
}