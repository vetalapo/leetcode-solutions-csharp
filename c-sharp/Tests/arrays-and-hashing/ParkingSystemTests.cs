using NUnit.Framework;

using Problems;

public class ParkingSystemTests
{
    [Test]
    public void AddCarTest()
    {
        ParkingSystem parkingSystem = new( 1, 1, 0 );

        Assert.IsTrue( parkingSystem.AddCar( 1 ) );
        Assert.IsTrue( parkingSystem.AddCar( 2 ) );
        Assert.IsFalse( parkingSystem.AddCar( 3 ) );
        Assert.IsFalse( parkingSystem.AddCar( 1 ) );
    }
}
