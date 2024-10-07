using NUnit.Framework;

using Problems;

public class BestTimeToBuyAndSellStockTests
{
    [TestCase( new int[] { 7, 1, 5, 3, 6, 4 }, ExpectedResult = 5 )]
    [TestCase( new int[] { 7, 6, 4, 3, 1 }, ExpectedResult = 0 )]
    public int MaxProfitTest( int[] prices ) =>
        new BestTimeToBuyAndSellStock().MaxProfit( prices );
}
