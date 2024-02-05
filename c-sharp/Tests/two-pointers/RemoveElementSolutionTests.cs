using NUnit.Framework;

using Problems;

public class RemoveElementSolutionTests
{
    [TestCase( new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 1, 4, 0, 3 }, ExpectedResult = 5 )]
    [TestCase( new int[] { 1 }, 1, new int[] { }, ExpectedResult = 0 )]
    public int RemoveElementTest( int[] nums, int val, int[] expectedNumsResult )
    {
        int amountElementsLeft = new RemoveElementSolution().RemoveElement( nums, val );

        Assert.AreEqual( nums.Take( amountElementsLeft ), expectedNumsResult );

        return amountElementsLeft;
    }
}
