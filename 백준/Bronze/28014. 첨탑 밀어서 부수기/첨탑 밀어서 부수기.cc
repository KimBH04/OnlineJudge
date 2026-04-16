#include <iostream>
using namespace std;

int main()
{
    cin.tie(NULL);
    cout.tie(NULL);
    ios_base::sync_with_stdio(0);

    int n, b = 0, r = 0;

    cin >> n;
    while (n--)
    {
        int a;
        cin >> a;
        if (b <= a)
        {
            r++;
        }
        b = a;
    }

    cout << r;

    return 0;
}