﻿using System.Collections.Generic;

using NUnit.Framework;

using Problems;

public class EncodeAndDecodeStringsTests
{
    [TestCase( [new string[] { "lint", "code", "love", "you" }], ExpectedResult = "4#lint4#code4#love3#you" )]
    [TestCase( [new string[] { "we", "say", ":", "yes" }], ExpectedResult = "2#we3#say1#:3#yes" )]
    public string EncodeTest( IList<string> strs ) =>
        new EncodeAndDecodeStrings().Encode( strs );

    [TestCase( "4#lint4#code4#love3#you", ExpectedResult = new string[] { "lint", "code", "love", "you" } )]
    [TestCase( "2#we3#say1#:3#yes", ExpectedResult = new string[] { "we", "say", ":", "yes" } )]
    public IList<string> DecodeTest( string str ) =>
        new EncodeAndDecodeStrings().Decode( str );
}
