using NUnit.Framework;

using Problems;

public class IntersectionOfTwoArraysTests
{
    [TestCase( new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }, ExpectedResult = new int[] { 2 } )]
    [TestCase( new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, ExpectedResult = new int[] { 9, 4 } )]
    public int[] IntersectionTest( int[] nums1, int[] nums2 ) =>
        new IntersectionOfTwoArrays().Intersection( nums1, nums2 );
}
