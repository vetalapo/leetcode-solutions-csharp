using System.Collections;

using NUnit.Framework;

using Problems;

public class CountingWordsWithAGivenPrefixTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int PrefixCountTest( string[] words, string pref ) =>
        new CountingWordsWithAGivenPrefix().PrefixCount( words, pref );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new string[] { "pay", "attention", "practice", "attend" }, "at"] ).Returns( 2 );

            yield return new TestCaseData( [new string[] { "leetcode", "win", "loops", "success" }, "code"] ).Returns( 0 );

            yield return new TestCaseData(
                [
                    new string[]
                    {
                        "kttxeksggb", "vucqwew", "lyknscc", "mryl", "vwarnwkfmd", "ivawxbntgs", "mylw",
                        "namybmfy", "uosag", "rzernqxyn", "puf", "hfwjnmvm", "jjfyd", "xteybd", "v",
                        "ywntwzn", "npsogop", "brgvlw", "vewhi", "brk", "hheub", "zl", "vt", "bxjtjivep",
                        "p", "io", "xotulskjmt", "mctffonh", "pmeuqhoe", "ghktrtq", "u", "ngnvwan", "pqmlvvhl",
                        "enjf", "qomcejb", "twgqww", "bnilyqy", "nc", "fttlodnz", "fya", "g", "uoivsr", "gtxgcaf",
                        "qs", "gkfl", "sdmacxf", "mzy", "xjv", "yipc", "rctqugjjk", "myij", "xxg", "vyup",
                        "utqxplpsa", "imbteaczlc", "qfgdcz", "atfn", "pxcsg", "f", "omukbiaudb", "uh",
                        "uobwgt", "hgqipk", "zunfzinenk", "i", "p", "pet", "fxai", "ortqpwkukg", "rxgh", "ylfh"
                    }, "ikwjoty"
                ] ).Returns( 0 );
        }
    }
}
