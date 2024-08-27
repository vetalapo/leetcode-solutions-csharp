using NUnit.Framework;

using Problems;

public class TimeNeededToBuyTicketsTests
{
    [TestCase( new int[] { 2, 3, 2 }, 2, ExpectedResult = 6 )]
    [TestCase( new int[] { 5, 1, 1, 1 }, 0, ExpectedResult = 8 )]
    public int TimeRequiredToBuyTest( int[] tickets, int k ) =>
        new TimeNeededToBuyTickets().TimeRequiredToBuy( tickets, k );
}
