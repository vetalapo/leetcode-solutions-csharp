using NUnit.Framework;

using Problems;

public class MedianOfTwoSortedArraysTests
{
    [TestCase( new int[] { 1, 3 }, new int[] { 2 }, ExpectedResult = 2.0 )]
    [TestCase( new int[] { 1, 2 }, new int[] { 3, 4 }, ExpectedResult = 2.5 )]
    [TestCase( new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 4 )]
    [TestCase( new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 3.5 )]
    [TestCase( new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 2, 3, 4 }, ExpectedResult = 3.5 )]
    [TestCase( new int[] { 1, 1, 2, 3, 5, 8, 13, 21 }, new int[] { 2, 3, 5, 7, 11, 13, 17, 19 }, ExpectedResult = 6 )]
    [TestCase( new int[] { }, new int[] { 1 }, ExpectedResult = 1 )]
    [TestCase( new int[] { }, new int[] { 2, 3 }, ExpectedResult = 2.5 )]
    public double FindMedianSortedArraysTest( int[] nums1, int[] nums2 ) => new MedianOfTwoSortedArrays().FindMedianSortedArrays( nums1, nums2 );
}
