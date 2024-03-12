using System.Text;

public class ListNode( int val = 0, ListNode next = null )
{
    public int val = val;
    public ListNode next = next;

    public static ListNode Create( int[] values )
    {
        ListNode result = null;

        for ( int i = values.Length - 1; i >= 0; i-- )
        {
            result = new ListNode( values[i], result );
        }

        return result;
    }

    public static int[] GetValues( ListNode node )
    {
        List<int> result = [];

        while ( node != null )
        {
            result.Add( node.val );

            node = node.next;
        }

        return [.. result];
    }

    public override bool Equals( object? obj )
    {
        return obj is ListNode node &&
                 val == node.val &&
                EqualityComparer<ListNode>.Default.Equals( next, node.next );
    }

    public override string ToString()
    {
        StringBuilder result = new();
        ListNode node = new( val, next );

        while ( node != null )
        {
            result.Append( $"{node.val} " );
            node = node.next;
        }

        result.Remove( result.Length - 1, 1 );

        return result.ToString();
    }
}
