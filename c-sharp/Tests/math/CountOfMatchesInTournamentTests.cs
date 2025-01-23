using NUnit.Framework;

using Problems;

public class CountOfMatchesInTournamentTests
{
    [TestCase( 7, ExpectedResult = 6 )]
    [TestCase( 14, ExpectedResult = 13 )]
    public int NumberOfMatchesTest( int n ) =>
        new CountOfMatchesInTournament().NumberOfMatches( n );
}
