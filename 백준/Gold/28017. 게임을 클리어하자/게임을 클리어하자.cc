#include <algorithm>
#include <iostream>
using namespace std;

int main()
{
    int n, m, a[500][500], d[500][500];
    cin >> n >> m;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            cin >> a[i][j];
            d[i][j] = 5000001;
        }
    }

    for (int i = 0; i < m; i++)
    {
        d[0][i] = a[0][i];
    }

    for (int i = 1; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < m; k++)
            {
                if (j == k)
                    continue;

                d[i][j] = min(d[i][j], a[i][j] + d[i - 1][k]);
            }
        }
    }

    int _min = 5000001;
    for (int i = 0; i < m; i++)
    {
        _min = min(_min, d[n - 1][i]);
    }

    cout << _min;

    return 0;
}