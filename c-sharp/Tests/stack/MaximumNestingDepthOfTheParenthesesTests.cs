using NUnit.Framework;

using Problems;

public class MaximumNestingDepthOfTheParenthesesTests
{
    [TestCase( "(1+(2*3)+((8)/4))+1", ExpectedResult = 3 )]
    [TestCase( "(1)+((2))+(((3)))", ExpectedResult = 3 )]
    public int MaxDepthTest( string s ) =>
        new MaximumNestingDepthOfTheParentheses().MaxDepth( s );
}
