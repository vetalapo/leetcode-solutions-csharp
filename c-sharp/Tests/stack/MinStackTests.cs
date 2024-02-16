using NUnit.Framework;

using Problems;

public class MinStackTests
{
    [Test]
    public void MinStackTest()
    {
        // Arrange
        MinStack minStack = new();

        // Act
        minStack.Push( -2 );
        minStack.Push( 0 );
        minStack.Push( -3 );

        // Assert
        Assert.AreEqual( minStack.GetMin(), -3 );

        minStack.Pop();

        Assert.AreEqual( minStack.Top(), 0 );
        Assert.AreEqual( minStack.GetMin(), -2 );
    }

    [Test]
    public void MinStackMinCheckTest()
    {
        // Arrange
        MinStack minStack = new();

        // Act
        minStack.Push( -2 );

        // Assert
        Assert.AreEqual( minStack.Top(), -2 );
        Assert.AreEqual( minStack.GetMin(), -2 );
    }
}
