using System.IO;
using Antlr4.Runtime;

namespace AntlrExample
{
    internal class ErrorListener : IAntlrErrorListener<IToken>
    {
        public void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            //throw new System.NotImplementedException();
        }
    }
}