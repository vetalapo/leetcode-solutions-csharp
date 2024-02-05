using NUnit.Framework;

using Problems;

public class ConvertTheTemperatureTests
{
    [TestCase( 36.50, ExpectedResult = new double[] { 309.65000, 97.70000 } )]
    [TestCase( 122.11, ExpectedResult = new double[] { 395.26000, 251.79800 } )]
    public double[] ConvertTemperatureTest( double celsius ) => new ConvertTheTemperature().ConvertTemperature( celsius );
}
