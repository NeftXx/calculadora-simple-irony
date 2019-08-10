using Irony.Ast;
using Irony.Parsing;

namespace Calculadora.Ast
{
    public abstract class Operacion : Expresion
    {
        protected Expresion expresion1;
        protected Expresion expresion2;

        public override void Init(AstContext context, ParseTreeNode parseNode)
        {
            base.Init(context, parseNode);            
            expresion1 = (Expresion)Nodes[0].AstNode;
            expresion2 = (Expresion)Nodes[2].AstNode;
        }
    }
}
