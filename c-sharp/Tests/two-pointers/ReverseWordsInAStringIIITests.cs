using NUnit.Framework;

using Problems;

public class ReverseWordsInAStringIIITests
{
    [TestCase( "Let's take LeetCode contest", ExpectedResult = "s'teL ekat edoCteeL tsetnoc" )]
    [TestCase( "Mr Ding", ExpectedResult = "rM gniD" )]
    public string ReverseWordsTest( string s ) =>
        new ReverseWordsInAStringIII().ReverseWords( s );
}
