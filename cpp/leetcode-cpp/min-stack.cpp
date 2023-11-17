
using namespace std;

/*
    Design stack that supports push, pop, top, & retriving min element

    2 stacks, 1 normal & 1 monotonic decr, only push if lower than top

    Time: O(1)
    Space: O(n)
*/
class MinStack
{
    public:
    MinStack()
    {

    }

    void push( int val )
    {

    }

    void pop()
    {

    }

    int top()
    {

    }

    int getMin()
    {

    }
};

int main()
{
    MinStack* obj = new MinStack();
    obj->push( 10 );
    obj->pop();
    int param_3 = obj->top();
    int param_4 = obj->getMin();

    return 0;
}
