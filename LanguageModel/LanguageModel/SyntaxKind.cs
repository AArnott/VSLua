﻿namespace LanguageService
{
    public enum SyntaxKind
    {
        //Token Types
        EndKeyword,
        Identifier,
        OpenBracket,
        CloseBracket,
        OpenParen,
        CloseParen,
        OpenCurlyBrace,
        CloseCurlyBrace,
        Number,
        String,
        Unknown,
        EndOfFile,
        ThenKeyword,
        ElseKeyword,
        DoKeyword,
        RepeatKeyword,
        UntilKeyword,
        ElseIfKeyword,
        ModulusOperator,
        ExponentOperator,
        MinusOperator,
        TildeUnOp,
        LengthUnop,
        NotEqualsOperator,
        LessOrEqualOperator,
        GreaterOrEqualOperator,
        EqualityOperator,
        PlusOperator,
        MultiplyOperator,
        DivideOperator,
        FloorDivideOperator,
        BitwiseAndOperator,
        BitwiseRightOperator,
        BitwiseOrOperator,
        Dot,
        Comma,
        Semicolon,
        Colon,
        DoubleColon,
        AssignmentOperator,
        LessThanOperator,
        GreaterThanOperator,
        StringConcatOperator,
        BitwiseLeftOperator,
        AndBinop,
        BreakKeyword,
        FalseKeyValue,
        ForKeyword,
        FunctionKeyword,
        GotoKeyword,
        IfKeyword,
        InKeyword,
        LocalKeyword,
        NilKeyValue,
        NotUnop,
        OrBinop,
        WhileKeyword,
        TrueKeyValue,
        ReturnKeyword,
        MissingToken,
        VarArgOperator,
        UnterminatedString,
        IgnoreNewLineString,

        //Node Types
        ChunkNode,
        BlockNode,
        SemiColonStatementNode,
        FunctionCallStatementNode,
        ReturnStatementNode,
        BreakStatementNode,
        GoToStatementNode,
        DoStatementNode,
        WhileStatementNode,
        RepeatStatementNode,
        GlobalFunctionStatementNode,
        LocalAssignmentStatementNode,
        LocalFunctionStatementNode,
        SimpleForStatementNode,
        MultipleArgForStatementNode,
        LabelStatementNode,
        AssignmentStatementNode,
        IfStatementNode,
        ElseBlockNode,
        ElseIfBlockNode,
        SimpleExpression,
        BinaryOperatorExpression,
        UnaryOperatorExpression,
        TableConstructorExp,
        FunctionDef,
        BracketField,
        AssignmentField,
        ExpField,
        NameVar,
        SquareBracketVar,
        DotVar,
        FunctionCallExp,
        ParenPrefixExp,
        TableConstructorArg,
        ParenArg,
        StringArg,
        NameList,
        FieldList,
        ExpList,
        VarArgPar,
        NameListPar,
        VarList,
        FuncBodyNode,
        FuncNameNode,
        DotSeparatedNameList,
        SeparatedListElement,

        //Trivia type
        Whitespace,
        Comment,
        Newline
    }
}
