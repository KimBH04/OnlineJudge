#include <iostream>
#include <algorithm>

int n, k, bunker[3];
std::pair<int, int> town[50];

static inline int distance(int index1, int index2)
{
    auto a = town[index1];
    auto b = town[index2];
    return std::abs(a.first - b.first) + std::abs(a.second - b.second);
}

int back(int depth, int start)
{
    int m;
    if (depth >= k)
    {
        m = 0;
        for (int i = 0; i < n; i++)
        {
            int p = __INT_MAX__;
            for (int j = 0; j < k; j++)
            {  
                p = std::min(distance(i, bunker[j]), p);
            }
            m = std::max(m, p);
        }
        return m;
    }

    m = __INT_MAX__;
    for (int i = start; i < n; i++)
    {
        bunker[depth] = i;
        m = std::min(back(depth + 1, i + 1), m);
    }
    return m;
}

void solve()
{
    std::cin >> n >> k;
    for (int i = 0; i < n; i++)
    {
        int x, y;
        std::cin >> x >> y;
        town[i] = { x, y };
    }

    std::cout << back(0, 0) << std::endl;
}

int main()
{
    solve();
    return 0;
}