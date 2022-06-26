namespace Minsk.CodeAnalysis.Binding
{
    internal enum BoundNodeKind
    {
        // Statements
        BlockStatement,
        VariableDeclaration,
        ExpressionStatement,

        // Expressions
        LiteralExpression,
        VariableExpression,
        IfStatement,
        WhileStatement,
        ForStatement,
        AssignmentExpression,
        UnaryExpression,
        BinaryExpression,
    }
}