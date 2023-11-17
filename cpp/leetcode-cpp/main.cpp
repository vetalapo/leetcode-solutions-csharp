#include <iostream>

void ZeroInit( int* ptr )
{
    ptr = new int( 0 );
}

int main( int argc, char** argv )
{
    int* intPtr = nullptr;

    ZeroInit( intPtr );

    std::cout << *intPtr << std::endl;

    return 0;
}
