namespace leet_code_csharp.arrays_and_hashing;

public class ContainsDuplicateSolution
{
    public bool ContainsDuplicate( int[] nums )
    {
        HashSet<int> set = new();
        
        foreach( int i in nums )
        {
            if ( set.Contains( i ) )
            {
                return true;
            }

            set.Add( i );
        }

        return false;
    }
}
