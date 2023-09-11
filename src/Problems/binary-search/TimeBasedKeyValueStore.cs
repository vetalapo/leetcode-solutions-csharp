/**
 * 981
 * Time Based Key-Value Store
 **
 * Design a time-based key-value data structure that
 * can store multiple values for the same key at different time stamps
 * and retrieve the key's value at a certain timestamp.
 * 
 * Implement the TimeMap class:
 *   TimeMap() Initializes the object of the data structure.
 *   
 *   void set(String key, String value, int timestamp) Stores the key key with the value value at the given time timestamp.
 *   
 *   String get(String key, int timestamp) Returns a value such that set was called previously, with timestamp_prev <= timestamp.
 *     If there are multiple such values, it returns the value associated with the largest timestamp_prev.
 *     If there are no values, it returns "".
 * 
 * https://leetcode.com/problems/time-based-key-value-store/
 */

namespace Problems;

public class TimeMap
{
    private readonly Dictionary<string, List<(int timestamp, string value)>> _store;

    public TimeMap()
    {
        this._store = new Dictionary<string, List<(int timestamp, string value)>>();
    }

    public void Set( string key, string value, int timestamp )
    {
        if ( !this._store.ContainsKey( key ) )
        {
            this._store[key] = new List<(int timestamp, string value)>();
        }

        this._store[key].Add( (timestamp, value) );
    }

    public string Get( string key, int timestamp )
    {
        if ( this._store.TryGetValue( key, out List<(int timestamp, string value)>? values ) )
        {
            return values.LastOrDefault( x => x.timestamp <= timestamp ).value ?? string.Empty;
        }

        return string.Empty;
    }

    public string GetBinarySearch( string key, int timestamp )
    {
        string result = string.Empty;

        if ( !this._store.TryGetValue( key, out List<(int timestamp, string value)>? values ) )
        {
            return result;
        }

        int left = 0;
        int right = values.Count;

        while ( left < right )
        {
            int middle = left + ( ( right - left ) / 2 );

            if ( values[middle].timestamp == timestamp )
            {
                result = values[middle].value;

                return result;
            }
            else if ( values[middle].timestamp < timestamp )
            {
                left = middle + 1;
                result = values[middle].value;
            }
            else
            {
                right = middle;
            }
        }

        return result;
    }
}
