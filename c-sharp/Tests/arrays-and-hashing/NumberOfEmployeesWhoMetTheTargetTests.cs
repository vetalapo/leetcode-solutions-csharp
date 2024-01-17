using NUnit.Framework;

using Problems;

[TestFixture]
public class NumberOfEmployeesWhoMetTheTargetTests
{
    [TestCase( new int[] { 0, 1, 2, 3, 4 }, 2, ExpectedResult = 3 )]
    [TestCase( new int[] { 5, 1, 4, 2, 2 }, 6, ExpectedResult = 0 )]
    public int NumberOfEmployeesWhoMetTargetTest( int[] hours, int target )
        => new NumberOfEmployeesWhoMetTheTarget().NumberOfEmployeesWhoMetTarget( hours, target );
}
