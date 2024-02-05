using NUnit.Framework;

using Problems;

public class FindTheMaximumAchievableNumberTests
{
    [TestCase( 4, 1, ExpectedResult = 6 )]
    [TestCase( 3, 2, ExpectedResult = 7 )]
    public int TheMaximumAchievableXTest( int num, int t ) => new FindTheMaximumAchievableNumber().TheMaximumAchievableX( num, t );
}
