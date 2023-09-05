using NUnit.Framework;

namespace leet_code_csharp.two_pointers.Tests;

[TestFixture]
public class ContainerWithMostWaterTests
{
    [TestCase( new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, ExpectedResult = 49 )]
    [TestCase( new int[] { 1, 1 }, ExpectedResult = 1 )]
    public int MaxAreaTest( int[] height ) => new ContainerWithMostWater().MaxArea( height );
}