using NUnit.Framework;

using Problems;

public class NumberOfStudentsUnableToEatLunchTests
{
    [TestCase( new int[] { 1, 1, 0, 0 }, new int[] { 0, 1, 0, 1 }, ExpectedResult = 0 )]
    [TestCase( new int[] { 1, 1, 1, 0, 0, 1 }, new int[] { 1, 0, 0, 0, 1, 1 }, ExpectedResult = 3 )]
    public int CountStudentsTest( int[] students, int[] sandwiches ) =>
        new NumberOfStudentsUnableToEatLunch().CountStudents( students, sandwiches );
}
