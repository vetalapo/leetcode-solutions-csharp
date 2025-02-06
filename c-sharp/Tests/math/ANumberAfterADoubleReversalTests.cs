using NUnit.Framework;

using Problems;

public class ANumberAfterADoubleReversalTests
{
    [TestCase( 526, ExpectedResult = true )]
    [TestCase( 1800, ExpectedResult = false )]
    [TestCase( 0, ExpectedResult = true )]
    public bool IsSameAfterReversalsTest( int num ) =>
        new ANumberAfterADoubleReversal().IsSameAfterReversals( num );
}
