using NUnit.Framework;

using Problems;

public class ContainerWithMostWaterTests
{
    [TestCase( new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, ExpectedResult = 49 )]
    [TestCase( new int[] { 1, 1 }, ExpectedResult = 1 )]
    public int MaxAreaTest( int[] height ) => new ContainerWithMostWater().MaxArea( height );
}
