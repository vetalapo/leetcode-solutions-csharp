using NUnit.Framework;

using Problems;

public class JewelsAndStonesTests
{
    [TestCase( "aA", "aAAbbbb", ExpectedResult = 3 )]
    [TestCase( "z", "ZZ", ExpectedResult = 0 )]
    public int NumJewelsInStonesTest( string jewels, string stones ) =>
        new JewelsAndStones().NumJewelsInStones( jewels, stones );
}
