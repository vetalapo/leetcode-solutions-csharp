using NUnit.Framework;

namespace leet_code_csharp.arrays_and_hashing.Tests;

[TestFixture]
public class RunningSumOf1dArrayTests
{
    [TestCase( new int[] { 1, 2, 3, 4 }, ExpectedResult = new int[] { 1, 3, 6, 10 } )]
    [TestCase( new int[] { 1, 1, 1, 1, 1 }, ExpectedResult = new int[] { 1, 2, 3, 4, 5 } )]
    [TestCase( new int[] { 3, 1, 2, 10, 1 }, ExpectedResult = new int[] { 3, 4, 6, 16, 17 } )]
    public int[] RunningSumTest( int[] nums ) => new RunningSumOf1dArray().RunningSum( nums );
}