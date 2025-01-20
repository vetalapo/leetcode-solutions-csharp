using NUnit.Framework;

using Problems;

public class Maximum69NumberSolutionTests
{
    [TestCase( 9669, ExpectedResult = 9969 )]
    [TestCase( 9996, ExpectedResult = 9999 )]
    [TestCase( 9999, ExpectedResult = 9999 )]
    public int Maximum69NumberTest( int num ) =>
        new Maximum69NumberSolution().Maximum69Number( num );
}
