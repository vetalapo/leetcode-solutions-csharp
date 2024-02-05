using NUnit.Framework;

using Problems;

public class TruncateSentenceSolutionTests
{
    [TestCase( "Hello how are you Contestant", 4, ExpectedResult = "Hello how are you" )]
    [TestCase( "What is the solution to this problem", 4, ExpectedResult = "What is the solution" )]
    [TestCase( "chopper is not a tanuki", 5, ExpectedResult = "chopper is not a tanuki" )]
    public string TruncateSentenceTest( string s, int k ) => new TruncateSentenceSolution().TruncateSentence( s, k );
}
