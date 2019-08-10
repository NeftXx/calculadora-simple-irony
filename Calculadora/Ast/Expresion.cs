using Irony.Ast;
using Irony.Parsing;

namespace Calculadora.Ast
{
    public abstract class Expresion : IAstNodeInit
    {
        public BnfTerm Term;
        public SourceSpan Span { get; set; }
        public SourceLocation ErrorAnchor;
        public virtual string AsString { get; protected set; }
        public SourceLocation Location { get { return Span.Location; } }
        public ParseTreeNodeList Nodes { get; protected set; }

        public virtual void Init(AstContext context, ParseTreeNode parseNode)
        {            
            Term = parseNode.Term;
            Span = parseNode.Span;
            ErrorAnchor = Location;
            parseNode.AstNode = this;
            AsString = (Term == null ? GetType().Name : Term.Name);
            Nodes = parseNode.GetMappedChildNodes();
        }

        public abstract double Run();
    }
}
