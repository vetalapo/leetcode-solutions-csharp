using NUnit.Framework;

namespace leet_code_csharp.stack.Tests;

[TestFixture]
public class EvaluateReversePolishNotationTests
{
    [TestCase( new object[] { new string[] { "2", "1", "+", "3", "*" } }, ExpectedResult = 9 )]
    [TestCase( new object[] { new string[] { "4", "13", "5", "/", "+" } }, ExpectedResult = 6 )]
    [TestCase( new object[] { new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" } }, ExpectedResult = 22 )]
    public int EvalRPNTest( string[] tokens ) => new EvaluateReversePolishNotation().EvalRPN( tokens );
}
