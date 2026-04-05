#include <iostream>
using namespace std;

int main()
{
    int n;
    cin >> n;
    int d = 2;
    
    for (int i = 0; i < n; i++){
        d += d - 1;
    }
    
    cout << d * d;
    
    return 0;
}
