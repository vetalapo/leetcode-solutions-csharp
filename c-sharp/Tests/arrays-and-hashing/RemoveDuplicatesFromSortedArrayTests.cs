using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

using Problems;

public class RemoveDuplicatesFromSortedArrayTests
{
    [TestCase( new int[] { 1, 1, 2 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, ExpectedResult = 5 )]
    public int RemoveDuplicatesTest( int[] nums )
    {
        // Arrange
        RemoveDuplicatesFromSortedArray removeDuplicate = new();
        int[] uniqueNums = new HashSet<int>( nums ).ToArray();

        // Act
        int count = removeDuplicate.RemoveDuplicates( nums );

        // Assert
        for ( int i = 0; i < uniqueNums.Length; i++ )
        {
            Assert.AreEqual( uniqueNums[i], nums[i] );
        }

        return count;
    }
}
