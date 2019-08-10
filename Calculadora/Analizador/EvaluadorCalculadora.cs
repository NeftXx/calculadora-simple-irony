using Irony.Parsing;
using Calculadora.Ast;
using Irony;

namespace Calculadora.Analizador
{
    class EvaluadorCalculadora
    {
        private readonly GramaticaCalculadora gramatica;
        private readonly LanguageData lenguaje;
        private readonly Parser parser;

        public EvaluadorCalculadora()
        {
            gramatica = new GramaticaCalculadora();
            lenguaje = new LanguageData(gramatica);
            parser = new Parser(lenguaje);
        }

        public double Evaluar(string entrada)
        {
            ParseTree arbol = parser.Parse(entrada);
            //if (arbol.HasErrors())
            //{
            //    foreach (LogMessage m in Arbol.ParserMessages)
            //    {
            //        Console.Error.Write(m.Message);
            //        Console.Error.WriteLine(" on line " + m.Location.Line + " and column " + m.Location.Column);
            //    }
            //}
            double salida = ((Expresion)arbol.Root.AstNode).Run();
            return salida;
        }
    }
}
