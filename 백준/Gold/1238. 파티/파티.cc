#include <iostream>
#include <queue>

int n, m, x;
std::vector<std::pair<int, int>> *edges;

static inline std::vector<int> search()
{
    std::vector<int> weights(n + 1, __INT_MAX__);
    std::priority_queue<std::pair<int, int>> pq;
    pq.push({ x, weights[x] = 0 });
    while (!pq.empty())
    {
        auto e = pq.top(); pq.pop();
        if (weights[e.first] < e.second)
        {
            continue;
        }

        for (const auto &node : edges[e.first])
        {
            int value = e.second + node.second;
            if (weights[node.first] > value)
            {
                weights[node.first] = value;
                pq.push({ node.first, value });
            }
        }
    }

    return weights;
}

int main()
{
    std::cin >> n >> m >> x;
    edges = new std::vector<std::pair<int, int>>[n + 1];
    while (m-- > 0)
    {
        int a, b, t;
        std::cin >> a >> b >> t;
        edges[a].push_back({ b, t });
    }
    auto weight1 = search();

    auto *temp = new std::vector<std::pair<int, int>>[n + 1];
    for (int i = 1; i <= n; i++)
    {
        for (const auto &edge : edges[i])
        {
            temp[edge.first].push_back({ i, edge.second });
        }
    }
    delete[] edges;
    edges = temp;
    auto weight2 = search();

    int max = weight1[1] + weight2[1];
    for (int i = 2; i <= n; i++)
    {
        if (max < weight1[i] + weight2[i])
        {
            max = weight1[i] + weight2[i];
        }
    }
    std::cout << max << std::endl;
    return 0;
}