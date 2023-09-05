namespace leet_code_csharp.arrays_and_hashing
{
    public class GroupAnagramsSolution
    {
        public IList<IList<string>> GroupAnagrams( string[] strs )
        {
            Dictionary<string, IList<string>> groups = new();

            foreach ( string str in strs )
            {
                string key = GetHashKey( str );

                if ( !groups.ContainsKey( key ) )
                {
                    groups[key] = new List<string>();
                }

                groups[key].Add( str );
            }

            return groups.Values.ToList();
        }

        private string GetHashKey( string str )
        {
            char[] hash = new char[26];

            foreach ( char c in str )
            {
                hash[c - 'a']++;
            }

            return new string( hash );
        }
    }
}
