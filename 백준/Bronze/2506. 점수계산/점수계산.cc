#include <iostream>
using namespace std;

int main()
{
    int n, r = 0, i = 1;
    cin >> n;

    while (n--)
    {
        int x;
        cin >> x;
        if (x)
        {
            r += i;
            i++;
        }
        else
        {
            i = 1;
        }
    }

    cout << r;

    return 0;
}