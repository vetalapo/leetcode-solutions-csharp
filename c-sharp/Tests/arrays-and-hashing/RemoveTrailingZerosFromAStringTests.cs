using NUnit.Framework;

using Problems;

public class RemoveTrailingZerosFromAStringTests
{
    [TestCase( "51230100", ExpectedResult = "512301" )]
    [TestCase( "123", ExpectedResult = "123" )]
    public string RemoveTrailingZerosTest( string num ) =>
        new RemoveTrailingZerosFromAString().RemoveTrailingZeros( num );
}
