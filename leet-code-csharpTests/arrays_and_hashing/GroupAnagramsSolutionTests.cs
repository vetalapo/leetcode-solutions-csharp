using System.Collections;

using NUnit.Framework;

namespace leet_code_csharp.arrays_and_hashing.Tests;

[TestFixture]
public class GroupAnagramsSolutionTests
{
    [TestCaseSource( typeof( GroupAnagramsSolutionTests ), nameof( TestCases ) )]
    public IList<IList<string>> GroupAnagramsTest( string[] strs )
    {
        // Arrange
        GroupAnagramsSolution solution = new();

        // Act
        IList<IList<string>> result = solution.GroupAnagrams( strs );

        // Assert
        return result.OrderBy( x => x.Count() ).ToList();
    }
    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new object[] { new string[] { "eat", "tea", "tan", "ate", "nat", "bat" } } )
                .Returns( new List<IList<string>>()
                {
                    new List<string>() { "bat" }, new List<string>() { "tan", "nat" }, new List<string>() { "eat", "tea",  "ate" }
                } );

            yield return new TestCaseData( new object[] { new string[] { "" } } )
                .Returns( new List<IList<string>>() { new List<string>() { "" } } );

            yield return new TestCaseData( new object[] { new string[] { "a" } } )
                .Returns( new List<IList<string>>() { new List<string>() { "a" } } );
        }
    }
}
