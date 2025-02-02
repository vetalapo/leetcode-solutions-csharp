using NUnit.Framework;

using Problems;

public class SortThePeopleTests
{
    [TestCase( new string[] { "Mary", "John", "Emma" }, new int[] { 180, 165, 170 }, ExpectedResult = new string[] { "Mary", "Emma", "John" } )]
    [TestCase( new string[] { "Alice", "Bob", "Bob" }, new int[] { 155, 185, 150 }, ExpectedResult = new string[] { "Bob", "Alice", "Bob" } )]
    public string[] SortPeopleTest( string[] names, int[] heights ) =>
        new SortThePeople().SortPeople( names, heights );
}
