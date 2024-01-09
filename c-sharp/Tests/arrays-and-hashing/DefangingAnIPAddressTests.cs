using NUnit.Framework;

using Problems;

[TestFixture]
public class DefangingAnIPAddressTests
{
    [TestCase( "1.1.1.1", ExpectedResult = "1[.]1[.]1[.]1" )]
    [TestCase( "255.100.50.0", ExpectedResult = "255[.]100[.]50[.]0" )]
    public string DefangIPaddrTest( string address ) => new DefangingAnIPAddress().DefangIPaddr( address );
}
