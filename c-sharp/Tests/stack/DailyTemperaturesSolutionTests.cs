using NUnit.Framework;

using Problems;

public class DailyTemperaturesSolutionTests
{
    [TestCase( new object[] { new int[] { 73, 74, 75, 71, 69, 72, 76, 73 } }, ExpectedResult = new int[] { 1, 1, 4, 2, 1, 1, 0, 0 } )]
    [TestCase( new object[] { new int[] { 30, 40, 50, 60 } }, ExpectedResult = new int[] { 1, 1, 1, 0 } )]
    [TestCase( new object[] { new int[] { 30, 60, 90 } }, ExpectedResult = new int[] { 1, 1, 0 } )]
    public int[] DailyTemperaturesTest( int[] temperatures ) => new DailyTemperaturesSolution().DailyTemperatures( temperatures );
}
