namespace leet_code_csharp.arrays_and_hashing;

public class EncodeAndDecodeStrings
{
    public string Encode( IList<string> strs ) => string.Concat( strs.SelectMany( s => $"{s.Length}#{s}" ) );

    public IList<string> Decode( string str )
    {
        List<string> result = new();

        int i = 0;

        while ( i < str.Length )
        {
            int j = i;

            while ( str[j] != '#' )
            {
                j++;
            }

            int.TryParse( str.Substring( i, j - i ), out int currentWordLength );
            
            j++;

            result.Add( str.Substring( j, currentWordLength ) );

            i = j + currentWordLength;
        }

        return result;
    }
}
