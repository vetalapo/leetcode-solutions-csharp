using NUnit.Framework;

using Problems;

[TestFixture]
public class MinStackTests
{
    [Test]
    public void MinStackTest()
    {
        // Arrange
        MinStack stack = new();

        // Act
        stack.Push( -2 );
        stack.Push( 0 );
        stack.Push( -3 );

        // Assert
        Assert.AreEqual( stack.GetMin(), -3 );

        stack.Pop();

        Assert.AreEqual( stack.Top(), 0 );
        Assert.AreEqual( stack.GetMin(), -2 );
    }
}