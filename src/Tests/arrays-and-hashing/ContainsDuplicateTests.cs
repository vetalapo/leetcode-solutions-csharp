using NUnit.Framework;

using Problems;

[TestFixture]
public class ContainsDuplicateTests
{
    [TestCase( new int[] { 1, 2, 3, 1 }, ExpectedResult = true )]
    [TestCase( new int[] { 1, 2, 3, 4 }, ExpectedResult = false )]
    [TestCase( new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, ExpectedResult = true )]
    public bool ContainsDuplicateTest( int[] nums ) => new ContainsDuplicateSolution().ContainsDuplicate( nums );
}