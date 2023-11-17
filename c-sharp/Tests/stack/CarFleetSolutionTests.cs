using NUnit.Framework;

using Problems;

[TestFixture]
public class CarFleetSolutionTests
{
    [TestCase( 12, new int[] { 10, 8, 0, 5, 3 }, new int[] { 2, 4, 1, 1, 3 }, ExpectedResult = 3 )]
    [TestCase( 10, new int[] { 3 }, new int[] { 3 }, ExpectedResult = 1 )]
    [TestCase( 100, new int[] { 0, 2, 4 }, new int[] { 4, 2, 1 }, ExpectedResult = 1 )]
    [TestCase( 10, new int[] { 0, 4, 2 }, new int[] { 2, 1, 3 }, ExpectedResult = 1 )]
    public int CarFleetTest( int target, int[] position, int[] speed ) => new CarFleetSolution().CarFleet( target, position, speed );
}