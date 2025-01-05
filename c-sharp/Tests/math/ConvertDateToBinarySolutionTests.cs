using NUnit.Framework;

using Problems;

public class ConvertDateToBinarySolutionTests
{
    [TestCase( "2080-02-29", ExpectedResult = "100000100000-10-11101" )]
    [TestCase( "1900-01-01", ExpectedResult = "11101101100-1-1" )]
    public string ConvertDateToBinaryTest( string date ) =>
        new ConvertDateToBinarySolution().ConvertDateToBinary( date );
}
