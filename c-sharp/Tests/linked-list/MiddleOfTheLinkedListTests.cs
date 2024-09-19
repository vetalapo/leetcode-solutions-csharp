using FluentAssertions;

using NUnit.Framework;

using Problems;

public class MiddleOfTheLinkedListTests
{
    [Test]
    public void MiddleNodeOneToFiveTest()
    {
        // Arrange
        ListNode input = new( 1, new( 2, new( 3, new( 4, new( 5 ) ) ) ) );
        ListNode expectedResult = new( 3, new( 4, new( 5 ) ) );

        // Act
        ListNode testObject = new MiddleOfTheLinkedList().MiddleNode( input );

        // Assert
        testObject.Should().BeEquivalentTo( expectedResult );
    }

    [Test]
    public void MiddleNodeOneToSixTest()
    {
        // Arrange
        ListNode input = new( 1, new( 2, new( 3, new( 4, new( 5, new( 6 ) ) ) ) ) );
        ListNode expectedResult = new( 4, new( 5, new( 6 ) ) );

        // Act
        ListNode testObject = new MiddleOfTheLinkedList().MiddleNode( input );

        // Assert
        testObject.Should().BeEquivalentTo( expectedResult );
    }
}
