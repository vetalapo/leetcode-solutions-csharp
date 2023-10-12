using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

using Problems;

namespace Benchmarks;

[MemoryDiagnoser]
[Orderer( SummaryOrderPolicy.FastestToSlowest )]
[RankColumn]
public class LongestSubstringWithoutRepeatingCharactersBenchmarks
{
    private static readonly LongestSubstringWithoutRepeatingCharacters LongestSubstringWithoutRepeating = new();
    private static readonly string TestString =
        "a80tkzfhpx24i67vn4vr6wxj73hgzt0vqtzn7ynhiakckzeidn4yaghfpv6c5ei7atdb6xbcm4pgedujihzy0hb5uqyx9nk9qrgg35g" +
        "90mg3k96aum94v06zffkw6b0w56xfkfjz00yetgnd9ffqnvkm38wt8y2a932wmu5uin8jfy4h6w3qf06gjtgqy7dwwa5mbbtcwkgbxm" +
        "6fuhnr0p2ammwbccb3j9q2az98z0qiagbqut649p0hwpxhgjyh2z857803wnkjkmn4jrek53c26n3x9mqdkr38p7cnjeggzyqg3e2hc" +
        "mr07nagq2yq3rz669warw1rjvz47qkmjm0b5909qzcwbid5fegm20dy1ftcej3602g0m6bne5z2gnfdvw8aa4tpa4rtpm76yhjau4p6" +
        "8k2n36pja562c9k3mjtcgw3pd36v7xrv3npvtxbd2f6japei07ek16rq0dzz3rhxvid8z23krzwtwa3gtgjzeffnpg7rw4y3kg8kp4c" +
        "82w2phqzveivza2tn7ibaj3ked2zi8atgjc91yctz69h6pbe17d0yn10fxh0mgy3jcdfwcph84ga7795qk4mxjxtfmqqu2uhzy1290p" +
        "yp7abfd01pv06ap661cq3445mqn30x8j4226y4ipqyrfq8wvjynuprbeivpytmp5760f7w35b50vw0vzzkfb5yvyrnwuvwvh2x18rb3" +
        "i1kdjkddaezde2rpwk8xbpz5z7qd6u31z2b1kwfx3xpcby3he6y1gwnz81ee87ct9r0u1yi12ain0f14f3ja1093d8yya0ixrzagnr8" +
        "mmyjjjtxdku0b3pv5p0fkccjna851m610hzgv9qf2vcyk8hfu37ujn5z084nvqc7rk1b9jgz014i4fj70cic4nrutaytw0z0qjq6gwb" +
        "fet6q1uaqc44uy7u6ajkwnp63th3ijt6m2wnnaa23721ceh6krvd03k91b21egr77tydy4y3e";

    [Benchmark]
    public void LengthOfLongestSubstring() => LongestSubstringWithoutRepeating.LengthOfLongestSubstring( TestString );

    [Benchmark]
    public void LengthOfLongestSubstringPointers() => LongestSubstringWithoutRepeating.LengthOfLongestSubstringPointers( TestString );
}
