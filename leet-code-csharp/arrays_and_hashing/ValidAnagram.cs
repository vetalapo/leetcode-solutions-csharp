namespace leet_code_csharp.arrays_and_hashing;

public class ValidAnagram
{
    public bool IsAnagram( string s, string t )
    {
        if ( s.Length != t.Length )
        {
            return false;
        }

        if ( s == t )
        {
            return true;
        }

        Dictionary<char, int> sCounts = new Dictionary<char, int>();
        Dictionary<char, int> tCounts = new Dictionary<char, int>();

        for ( int i = 0; i < s.Length; i++ )
        {
            sCounts[s[i]] = 1 + ( sCounts.ContainsKey( s[i] ) ? sCounts[s[i]] : 0 );
            tCounts[t[i]] = 1 + ( tCounts.ContainsKey( t[i] ) ? tCounts[t[i]] : 0 );
        }

        foreach ( char c in sCounts.Keys )
        {
            if ( !tCounts.ContainsKey( c ) )
            {
                return false;
            }

            if ( sCounts[c] != tCounts[c] )
            {
                return false;
            }
        }

        return true;
    }

    public bool IsAnagramBySorting( string s, string t )
    {
        if ( s.Length != t.Length )
        {
            return false;
        }

        if ( s == t )
        {
            return true;
        }

        char[] sCharacters = s.ToArray();
        Array.Sort( sCharacters );

        char[] tCharacters = t.ToArray();
        Array.Sort( tCharacters );

        return new string( sCharacters ) == new string( tCharacters );
    }
}
