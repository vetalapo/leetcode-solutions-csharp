using NUnit.Framework;

using Problems;

[TestFixture]
public class TopKFrequentElementsTests
{
    [TestCase( new int[] { 1, 1, 1, 2, 2, 3 }, 2, ExpectedResult = new int[] { 1, 2 } )]
    [TestCase( new int[] { 1 }, 1, ExpectedResult = new int[] { 1 } )]
    public int[] TopKFrequentTest( int[] nums, int k ) => new TopKFrequentElements().TopKFrequent( nums, k );
}
