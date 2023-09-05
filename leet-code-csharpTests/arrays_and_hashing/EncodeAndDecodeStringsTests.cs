using NUnit.Framework;

namespace leet_code_csharp.arrays_and_hashing.Tests;

[TestFixture]
public class EncodeAndDecodeStringsTests
{
    [TestCase( new object[] { new string[] { "lint", "code", "love", "you" } }, ExpectedResult = "4#lint4#code4#love3#you" )]
    [TestCase( new object[] { new string[] { "we", "say", ":", "yes" } }, ExpectedResult = "2#we3#say1#:3#yes" )]
    public string EncodeTest( IList<string> strs ) => new EncodeAndDecodeStrings().Encode( strs );

    [TestCase( "4#lint4#code4#love3#you", ExpectedResult = new string[] { "lint", "code", "love", "you" } )]
    [TestCase( "2#we3#say1#:3#yes", ExpectedResult = new string[] { "we", "say", ":", "yes" } )]
    public IList<string> DecodeTest( string str ) => new EncodeAndDecodeStrings().Decode( str );
}