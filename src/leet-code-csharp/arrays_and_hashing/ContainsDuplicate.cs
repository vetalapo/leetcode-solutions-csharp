/*
 * 217
 * Contains Duplicate
 * 
 * Given an integer array nums,
 * return true if any value appears at least twice in the array,
 * and return false if every element is distinct.
 * 
 * https://leetcode.com/problems/contains-duplicate/
 */

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
