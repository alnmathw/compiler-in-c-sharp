using Compiler.CodeAnalysis.Syntax;

namespace Compiler.CodeAnalysis.Binding
{
    internal sealed class BoundGotoStatement : BoundStatement
    {
        public BoundGotoStatement(SyntaxNode syntax, BoundLabel label)
            : base(syntax)
        {
            Label = label;
        }

        public override BoundNodeKind Kind => BoundNodeKind.GotoStatement;
        public BoundLabel Label { get; }
    }
}
