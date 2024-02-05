using NUnit.Framework;

using Problems;

public class SubtractProductAndSumDigitsOfIntegerTests
{
    [TestCase( 234, ExpectedResult = 15 )]
    [TestCase( 4421, ExpectedResult = 21 )]
    public int SubtractProductAndSumTest( int n ) => new SubtractProductAndSumDigitsOfInteger().SubtractProductAndSum( n );
}
