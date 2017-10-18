//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\nahuel\Desktop\Diseño\TpDiuj\TpIntegradorDiuj\grammarTest.g4 by ANTLR 4.6.4

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace TpIntegradorDiuj {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="grammarTestParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.4")]
[System.CLSCompliant(false)]
public interface IgrammarTestVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>Multiplication</c>
	/// labeled alternative in <see cref="grammarTestParser.multOrDiv"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplication([NotNull] grammarTestParser.MultiplicationContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Division</c>
	/// labeled alternative in <see cref="grammarTestParser.multOrDiv"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDivision([NotNull] grammarTestParser.DivisionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ToPow</c>
	/// labeled alternative in <see cref="grammarTestParser.multOrDiv"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitToPow([NotNull] grammarTestParser.ToPowContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Calculate</c>
	/// labeled alternative in <see cref="grammarTestParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCalculate([NotNull] grammarTestParser.CalculateContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ToSetVar</c>
	/// labeled alternative in <see cref="grammarTestParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitToSetVar([NotNull] grammarTestParser.ToSetVarContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>SetVariable</c>
	/// labeled alternative in <see cref="grammarTestParser.setVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSetVariable([NotNull] grammarTestParser.SetVariableContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ToMultOrDiv</c>
	/// labeled alternative in <see cref="grammarTestParser.plusOrMinus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitToMultOrDiv([NotNull] grammarTestParser.ToMultOrDivContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Plus</c>
	/// labeled alternative in <see cref="grammarTestParser.plusOrMinus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPlus([NotNull] grammarTestParser.PlusContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Minus</c>
	/// labeled alternative in <see cref="grammarTestParser.plusOrMinus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMinus([NotNull] grammarTestParser.MinusContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ChangeSign</c>
	/// labeled alternative in <see cref="grammarTestParser.unaryMinus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChangeSign([NotNull] grammarTestParser.ChangeSignContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ToAtom</c>
	/// labeled alternative in <see cref="grammarTestParser.unaryMinus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitToAtom([NotNull] grammarTestParser.ToAtomContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Power</c>
	/// labeled alternative in <see cref="grammarTestParser.pow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPower([NotNull] grammarTestParser.PowerContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ConstantPI</c>
	/// labeled alternative in <see cref="grammarTestParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantPI([NotNull] grammarTestParser.ConstantPIContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Variable</c>
	/// labeled alternative in <see cref="grammarTestParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariable([NotNull] grammarTestParser.VariableContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Braces</c>
	/// labeled alternative in <see cref="grammarTestParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBraces([NotNull] grammarTestParser.BracesContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ConstantE</c>
	/// labeled alternative in <see cref="grammarTestParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantE([NotNull] grammarTestParser.ConstantEContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Double</c>
	/// labeled alternative in <see cref="grammarTestParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDouble([NotNull] grammarTestParser.DoubleContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Int</c>
	/// labeled alternative in <see cref="grammarTestParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInt([NotNull] grammarTestParser.IntContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="grammarTestParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInput([NotNull] grammarTestParser.InputContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="grammarTestParser.setVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSetVar([NotNull] grammarTestParser.SetVarContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="grammarTestParser.plusOrMinus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPlusOrMinus([NotNull] grammarTestParser.PlusOrMinusContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="grammarTestParser.multOrDiv"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultOrDiv([NotNull] grammarTestParser.MultOrDivContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="grammarTestParser.pow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPow([NotNull] grammarTestParser.PowContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="grammarTestParser.unaryMinus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryMinus([NotNull] grammarTestParser.UnaryMinusContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="grammarTestParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtom([NotNull] grammarTestParser.AtomContext context);
}
} // namespace TpIntegradorDiuj