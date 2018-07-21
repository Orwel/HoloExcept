namespace Holo.Except.Arguments
{
    public class SourcePath : Path
    {
        private readonly string[] args;

        public SourcePath(string[] args)
        {
            this.args = args;
        }

        public string Value => args[0];
    }
}