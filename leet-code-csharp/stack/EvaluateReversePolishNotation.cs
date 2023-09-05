namespace leet_code_csharp.stack;

public class EvaluateReversePolishNotation
{
    public int EvalRPN( string[] tokens )
    {
        Stack<int> stack = new();

        foreach ( string token in tokens )
        {
            bool isNumber = int.TryParse( token, out int number );

            if ( isNumber )
            {
                stack.Push( number );
            }
            else
            {
                stack.Push( Evaluate( stack.Pop(), stack.Pop(), token ) );
            }
        }

        return stack.Pop();
    }

    private int Evaluate( int b, int a, string token )
    {
        return token switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => a / b,
            _ => throw new NotSupportedException()
        };
    }
}
