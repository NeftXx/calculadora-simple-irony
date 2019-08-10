using Irony.Ast;
using Irony.Parsing;
using System;

namespace Calculadora.Ast
{
    public class Numero : Expresion
    {
        protected double value;

        public override void Init(AstContext context, ParseTreeNode parseNode)
        {
            base.Init(context, parseNode);
            value = Convert.ToDouble(parseNode.Token.Text);
        }

        public override double Run()
        {
            return value;
        }
    }
}
