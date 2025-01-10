using NUnit.Framework;

using Problems;

public class MaximumNumberOfWordsFoundInSentencesTests
{
    [TestCase( [new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" }], ExpectedResult = 6 )]
    [TestCase( [new string[] { "please wait", "continue to fight", "continue to win" }], ExpectedResult = 3 )]
    public int MostWordsFoundTest( string[] sentences ) =>
        new MaximumNumberOfWordsFoundInSentences().MostWordsFound( sentences );
}
