using NUnit.Framework;

using Problems;

public class SortingTheSentenceTests
{
    [TestCase( "is2 sentence4 This1 a3", ExpectedResult = "This is a sentence" )]
    [TestCase( "Myself2 Me1 I4 and3", ExpectedResult = "Me Myself and I" )]
    public string SortSentenceTest( string s ) =>
        new SortingTheSentence().SortSentence( s );
}
