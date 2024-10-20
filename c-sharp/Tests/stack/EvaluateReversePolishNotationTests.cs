using NUnit.Framework;

using Problems;

public class EvaluateReversePolishNotationTests
{
    [TestCase( [new string[] { "2", "1", "+", "3", "*" }], ExpectedResult = 9 )]
    [TestCase( [new string[] { "4", "13", "5", "/", "+" }], ExpectedResult = 6 )]
    [TestCase( [new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }], ExpectedResult = 22 )]
    public int EvalRPNTest( string[] tokens )
        => new EvaluateReversePolishNotation().EvalRPN( tokens );
}
