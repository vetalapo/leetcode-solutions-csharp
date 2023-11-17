using System.Text;

public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node( int val )
    {
        this.val = val;
        this.next = null;
        this.random = null;
    }

    // [[7,null],[13,0],[11,4],[10,2],[1,0]]
    public static Node Create( int?[][] arr )
    {
        Node[] indexedNodes = new Node[arr.Length];

        for ( int i = 0; i < arr.Length; i++ )
        {
            (int? val, int? randomNodeIndex) item = (arr[i][0], arr[i][1]);
            indexedNodes[i] = new Node( val: (int)item.val );
        }
        
        Node result = null;

        for ( int i = arr.Length - 1; i >= 0; i-- )
        {
            (int? val, int? randomNodeIndex) item = (arr[i][0], arr[i][1]);

            indexedNodes[i].next = result;
            result = (Node)indexedNodes[i];
        }

        return result;
    }

    public override bool Equals( object? obj )
    {
        return obj is Node node &&
                val == node.val &&
                EqualityComparer<Node>.Default.Equals( next, node.next ) &&
                EqualityComparer<Node>.Default.Equals( random, node.random );
    }

    public override string ToString()
    {
        StringBuilder result = new();

        Node node = new( val )
        {
            next = next,
            random = random
        };

        while ( node != null )
        {
            result.Append( $"{node.val} " );
            node = node.next;
        }

        result.Remove( result.Length - 1, 1 );

        return result.ToString();
    }
}
