using NUnit.Framework;

using Problems;

public class StringCompressionIIITests
{
    [TestCase( "", ExpectedResult = "" )]
    [TestCase( "o", ExpectedResult = "1o" )]
    [TestCase( "mrm", ExpectedResult = "1m1r1m" )]
    [TestCase( "vvv", ExpectedResult = "3v" )]
    [TestCase( "abcde", ExpectedResult = "1a1b1c1d1e" )]
    [TestCase( "xxlaa", ExpectedResult = "2x1l2a" )]
    [TestCase( "xbbbbjj", ExpectedResult = "1x4b2j" )]
    [TestCase( "aaaaaaaaaaaaaabb", ExpectedResult = "9a5a2b" )]
    [TestCase( "yyyyyyyyfffccccqqwwffffffffrrrrrrrrraaaaayyyyyyyyy", ExpectedResult = "8y3f4c2q2w8f9r5a9y" )]
    [TestCase( "uuuuuuuuuuccccccvvvvvvvyyyyyyyylyyyqqqqqqqqqoaqqqq", ExpectedResult = "9u1u6c7v8y1l3y9q1o1a4q" )]
    [TestCase( "yyyyyyyyyyyyytttttttttttttttttttttttttttttttttttttttttttttttttt" +
        "vvvvvvvvvvvvvvvvvvvvvvvvvaaaaaaaaaajj", ExpectedResult = "9y4y9t9t9t9t9t5t9v9v7v9a1a2j" )]
    public string CompressedStringTest( string word ) =>
        new StringCompressionIII().CompressedString( word );
}
