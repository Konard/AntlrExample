using Antlr4.Runtime;
using System.IO;

namespace AntlrExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader fileStream = new StreamReader("Program.cs"))
            {
                AntlrInputStream inputStream = new AntlrInputStream(fileStream);

                CSharpLexer lexer = new CSharpLexer(inputStream);
                CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
                CSharpParser parser = new CSharpParser(commonTokenStream);

                parser.RemoveErrorListeners();
                parser.AddErrorListener(new ErrorListener()); // add ours

                var compilationUnit = parser.compilation_unit();

            }
        }
    }
}
