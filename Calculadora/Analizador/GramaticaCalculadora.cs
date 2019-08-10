using Irony.Parsing;
using Calculadora.Ast;

namespace Calculadora.Analizador
{
    class GramaticaCalculadora : Grammar
    {
        public GramaticaCalculadora()
        {
            var numero = new NumberLiteral("number");            
            numero.AstConfig.NodeType = typeof(Numero);
            NonTerminal E = new NonTerminal("E");
            NonTerminal SUMA = new NonTerminal("SUMA", typeof(Suma));
            NonTerminal RESTA = new NonTerminal("RESTA", typeof(Resta));
            NonTerminal MULT = new NonTerminal("MULT", typeof(Multiplicacion));
            NonTerminal DIV = new NonTerminal("DIV", typeof(Division));

            E.Rule = SUMA | RESTA | MULT | DIV | numero;
            SUMA.Rule = E + ToTerm("+") + E;
            RESTA.Rule = E + ToTerm("-") + E;
            MULT.Rule = E + ToTerm("*") + E;
            DIV.Rule = E + ToTerm("/") + E;

            RegisterOperators(1, "+", "-");//ESTABLESEMOS PRESEDENCIA
            RegisterOperators(2, "*", "/");

            MarkTransient(E);

            Root = E;
            LanguageFlags = LanguageFlags.CreateAst;    //IMPORTANTE PARA CREAR EL ARBOL SIN ESTO NO LO CREARA
        }
    }
}
