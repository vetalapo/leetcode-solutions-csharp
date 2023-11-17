using System.Text;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode( int val = 0, ListNode next = null )
    {
        this.val = val;
        this.next = next;
    }

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
        List<int> result = new();

        while ( node != null )
        {
            result.Add( node.val );

            node = node.next;
        }

        return result.ToArray();
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
