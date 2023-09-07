using NUnit.Framework;

namespace leet_code_csharp.binary_search.Tests;

[TestFixture]
public class SearchInRotatedSortedArrayTests
{
    [TestCase( new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, ExpectedResult = 4 )]
    [TestCase( new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, ExpectedResult = -1 )]
    [TestCase( new int[] { 4, 5, 6, 7, 8, 9, 0, 1, 2 }, 5, ExpectedResult = 1 )]
    [TestCase( new int[] { 4, 5, 6, 7, 8, 9, 0, 1, 2 }, 9, ExpectedResult = 5 )]
    [TestCase( new int[] { 4, 5, 6, 0, 1, 2, 3 }, 5, ExpectedResult = 1 )]
    [TestCase( new int[] { 1 }, 0, ExpectedResult = -1 )]
    [TestCase( new int[] { 5, 1, 2, 3, 4 }, 1, ExpectedResult = 1 )]
    public int SearchTest( int[] nums, int target ) => new SearchInRotatedSortedArray().Search( nums, target );
}