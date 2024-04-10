using NUnit.Framework;

using Problems;

public class RevealCardsInIncreasingOrderTests
{
    [TestCase( new int[] { 17, 13, 11, 2, 3, 5, 7 }, ExpectedResult = new int[] { 2, 13, 3, 11, 5, 17, 7 } )]
    [TestCase( new int[] { 1, 1000 }, ExpectedResult = new int[] { 1, 1000 } )]
    public int[] DeckRevealedIncreasingTest( int[] deck )
        => new RevealCardsInIncreasingOrder().DeckRevealedIncreasing( deck );
}
