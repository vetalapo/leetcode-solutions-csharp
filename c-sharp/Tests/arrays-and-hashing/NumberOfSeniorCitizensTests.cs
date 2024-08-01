using System.Collections;

using NUnit.Framework;

using Problems;

public class NumberOfSeniorCitizensTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public int CountSeniorsTest( string[] details ) =>
        new NumberOfSeniorCitizens().CountSeniors( details );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( [new string[] { }] ).Returns( 0 );

            yield return new TestCaseData( [new string[]
            {
                "7868190130M7522", "5303914400F9211", "9273338290F4010"
            }] )
                .Returns( 2 );

            yield return new TestCaseData( [new string[]
            {
                "1313579440F2036", "2921522980M5644"
            }] )
                .Returns( 0 );

            yield return new TestCaseData( [new string[]
            {
                "5612624052M0130", "5378802576M6424", "5447619845F0171", "2941701174O9078"
            }] )
                .Returns( 2 );

            yield return new TestCaseData( [new string[]
            {
                "9751302862F0693", "3888560693F7262", "5485983835F0649", "2580974299F6042",
                "9976672161M6561", "0234451011F8013", "4294552179O6482"
            }] )
                .Returns( 4 );

            yield return new TestCaseData( [new string[]
            {
                "1137774788O7691", "7472708234O0072", "9885137889M8868", "1321925389M8161",
                "5574709492O7158", "2205791488F8896", "1537217483M5762"
            }] )
                .Returns( 5 );

            yield return new TestCaseData( [new string[]
            {
                "4444444444F6030", "5555555555M7041", "6666666666O4055", "7777777777F6021"
            }] )
                .Returns( 1 );

            yield return new TestCaseData( [new string[]
            {
                "0000000000M9900", "1111111111F8801", "2222222222O6705", "3333333333M7604"
            }] )
                .Returns( 4 );

            yield return new TestCaseData( [new string[]
            {
                "9876543210M7012", "8765432109F8015", "7654321098O6013", "6543210987M5500"
            }] )
                .Returns( 2 );
        }
    }
}
