using NUnit.Framework;

public class CheckIfNandItsDoubleExistTests
{
    [TestCase( new int[] { 10, 2, 5, 3 }, ExpectedResult = true )]
    [TestCase( new int[] { 3, 1, 7, 11 }, ExpectedResult = false )]
    [TestCase( new int[] { 7, 1, 14, 11 }, ExpectedResult = true )]
    public bool CheckIfExistTest( int[] arr ) =>
        new CheckIfNandItsDoubleExist().CheckIfExist( arr );
}