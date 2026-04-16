#include <iostream>
#include <queue>

int main()
{
    int n, m, k, map[128][128];
    std::cin >> n >> m >> k;
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= m; j++)
        {
            map[i][j] = 0;
        }
    }
    
    while (k--)
    {
        int r, c;
        std::cin >> r >> c;
        map[r][c] = 1;
    }
    
    int max = 0;
    std::pair<int, int> DIR[] = {{1, 0}, {-1, 0}, {0, 1}, {0, -1}};
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= m; j++)
        {
            if (map[i][j])
            {
                map[i][j] = 0;
                std::queue<std::pair<int, int>> q;
                q.push({i, j});
                int cnt = 0;
                while (!q.empty())
                {
                    int r = q.front().first, c = q.front().second;
                    q.pop();
                    for (const auto &dir: DIR)
                    {
                        int tr = r + dir.first;
                        int tc = c + dir.second;
                        if (0 < tr && tr <= n && 0 < tc && tc <= m && map[tr][tc])
                        {
                            q.push({tr, tc});
                            map[tr][tc] = 0;
                        }
                    }
                    cnt++;
                }
                
                if (max < cnt)
                {
                    max = cnt;
                }
            }
        }
    }
    
    std::cout << max;
    
    return 0;
}