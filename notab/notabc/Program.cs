using System;
using notab.compiler.csharp;

namespace notab
{
    internal static class Program
    {
        internal static int Main(string[] args)
        {
            CommandLineInterface cli = new CommandLineInterface();
            
            CSharpCodeGenerator csharpGenerator = new CSharpCodeGenerator();
            cli.RegisterGenerator("-csharp_out", csharpGenerator); 
            
            return cli.Run(args);
        }
    }
}