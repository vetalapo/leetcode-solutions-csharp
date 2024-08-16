using NUnit.Framework;

using Problems;
public class MaximumOddBinaryNumberSolutionTests
{
    [TestCase( "010", ExpectedResult = "001" )]
    [TestCase( "0101", ExpectedResult = "1001" )]
    public string MaximumOddBinaryNumberTest( string s ) =>
        new MaximumOddBinaryNumberSolution().MaximumOddBinaryNumber( s );
}
