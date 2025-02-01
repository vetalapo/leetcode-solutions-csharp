using NUnit.Framework;

using Problems;

public class SpecialArrayITests
{
    [TestCase( new int[] { 1 }, ExpectedResult = true )]
    [TestCase( new int[] { 2, 1, 4 }, ExpectedResult = true )]
    [TestCase( new int[] { 4, 3, 1, 6 }, ExpectedResult = false )]
    public bool IsArraySpecialTest( int[] nums ) =>
        new SpecialArrayI().IsArraySpecial( nums );
}
