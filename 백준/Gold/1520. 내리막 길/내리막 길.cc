#include <iostream>
using namespace std;

int m,
    n,
    map[500][500],
    memo[500][500],
    dx[4]{ 0, 0, -1, 1 },
    dy[4]{ 1, -1, 0, 0 };

int depth(int x, int y)
{
    if (memo[x][y] > -1)
        return memo[x][y];

    int r = 0;
    for (int i = 0; i < 4; i++)
    {
        if (x + dx[i] >= 0 && x + dx[i] < n && y + dy[i] >= 0 && y + dy[i] < m)
        {
            if (map[x + dx[i]][y + dy[i]] < map[x][y])
            {
                r += depth(x + dx[i], y + dy[i]);
            }
        }
    }

    memo[x][y] = r;
    return r;
}

int main()
{
    cin >> m >> n;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            cin >> map[j][i];
            memo[j][i] = -1;
        }
    }

    memo[n - 1][m - 1] = 1;
    cout << depth(0, 0);

    return 0;
}