using NUnit.Framework;

using Problems;

[TestFixture]
public class GenerateParenthesesSolutionTests
{
    [TestCase( 3, ExpectedResult = new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" } )]
    [TestCase( 2, ExpectedResult = new string[] { "(())", "()()" } )]
    [TestCase( 1, ExpectedResult = new string[] { "()" } )]
    public IList<string> GenerateParenthesisTest( int n ) => new GenerateParenthesesSolution().GenerateParenthesis( n );
}
