using NUnit.Framework;

using Problems;

[TestFixture]
public class ReverseStringSolutionTest
{
    [TestCase( new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' } )]
    [TestCase( new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new char[] { 'h', 'a', 'n', 'n', 'a', 'H' } )]
    public void ReverseStringTest( char[] s, char[] expectedResult )
    {
        new ReverseStringSolution().ReverseString( s );

        Assert.AreEqual( s, expectedResult );
    }
}
