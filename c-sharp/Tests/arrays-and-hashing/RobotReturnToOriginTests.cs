using NUnit.Framework;

using Problems;

public class RobotReturnToOriginTests
{
    [TestCase( "UD", ExpectedResult = true )]
    [TestCase( "LL", ExpectedResult = false )]
    public bool JudgeCircleTest( string moves ) => new RobotReturnToOrigin().JudgeCircle( moves );
}
