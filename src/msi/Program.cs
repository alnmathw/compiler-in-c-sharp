namespace Compiler
{
    internal static class Program
    {
        private static void Main()
        {
            var repl = new CompilerRepl();
            repl.Run();
        }
    }
}
