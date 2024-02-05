using NUnit.Framework;

using Problems;

public class TimeBasedKeyValueStoreTests
{
    [Test]
    public void TimeBasedKeyValueStoreTest()
    {
        TimeMap timeMap = new();

        timeMap.Set( key: "foo", value: "bar", timestamp: 1 );

        Assert.AreEqual( expected: "bar", actual: timeMap.Get( "foo", 1 ) );
        Assert.AreEqual( expected: "bar", actual: timeMap.Get( "foo", 3 ) );

        timeMap.Set( "foo", "bar2", 4 );

        Assert.AreEqual( expected: "bar2", actual: timeMap.Get( "foo", 4 ) );
        Assert.AreEqual( expected: "bar2", actual: timeMap.Get( "foo", 5 ) );
    }

    [Test]
    public void TimeBasedKeyValueStoreBorderChecksTest()
    {
        TimeMap timeMap = new();

        timeMap.Set( key: "love", value: "high", timestamp: 10 );
        timeMap.Set( key: "love", value: "low", timestamp: 20 );

        Assert.AreEqual( expected: string.Empty, actual: timeMap.Get( "love", 5 ) );
        Assert.AreEqual( expected: "high", actual: timeMap.Get( "love", 10 ) );
        Assert.AreEqual( expected: "high", actual: timeMap.Get( "love", 15 ) );
        Assert.AreEqual( expected: "low", actual: timeMap.Get( "love", 20 ) );
        Assert.AreEqual( expected: "low", actual: timeMap.Get( "love", 25 ) );
    }

    [Test]
    public void TimeBasedKeyValueStoreBinarySearchTest()
    {
        TimeMap timeMap = new();

        timeMap.Set( key: "foo", value: "bar", timestamp: 1 );

        Assert.AreEqual( expected: "bar", actual: timeMap.GetBinarySearch( "foo", 1 ) );
        Assert.AreEqual( expected: "bar", actual: timeMap.GetBinarySearch( "foo", 3 ) );

        timeMap.Set( "foo", "bar2", 4 );

        Assert.AreEqual( expected: "bar2", actual: timeMap.GetBinarySearch( "foo", 4 ) );
        Assert.AreEqual( expected: "bar2", actual: timeMap.GetBinarySearch( "foo", 5 ) );
    }

    [Test]
    public void TimeBasedKeyValueStoreBinarySearchBorderChecksTest()
    {
        TimeMap timeMap = new();

        timeMap.Set( key: "love", value: "high", timestamp: 10 );
        timeMap.Set( key: "love", value: "low", timestamp: 20 );

        Assert.AreEqual( expected: string.Empty, actual: timeMap.GetBinarySearch( "love", 5 ) );
        Assert.AreEqual( expected: "high", actual: timeMap.GetBinarySearch( "love", 10 ) );
        Assert.AreEqual( expected: "high", actual: timeMap.GetBinarySearch( "love", 15 ) );
        Assert.AreEqual( expected: "low", actual: timeMap.GetBinarySearch( "love", 20 ) );
        Assert.AreEqual( expected: "low", actual: timeMap.GetBinarySearch( "love", 25 ) );
    }
}
