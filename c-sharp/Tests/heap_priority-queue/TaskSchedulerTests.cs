using NUnit.Framework;

using Problems;

public class TaskSchedulerTests
{
    [TestCase( new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 2, ExpectedResult = 8 )]
    [TestCase( new char[] { 'A', 'C', 'A', 'B', 'D', 'B' }, 1, ExpectedResult = 6 )]
    [TestCase( new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 3, ExpectedResult = 10 )]
    public int LeastIntervalTest( char[] tasks, int n ) =>
        new TaskScheduler().LeastInterval( tasks, n );
}
