#include <iostream>
#include <vector>

int max = 0;
std::vector<std::pair<int, int>> *edges;

int search(int n)
{
    int first = 0, second = 0;
    for (const auto &v : edges[n])
    {
        int weight = search(v.first) + v.second;
        if (first < weight)
        {
            second = first;
            first = weight;
        }
        else if (second < weight)
        {
            second = weight;
        }
    }

    int sum = first + second;
    if (max < sum)
    {
        max = sum;
    }

    return first;
}

int main()
{
    int n; std::cin >> n;

    edges = new std::vector<std::pair<int, int>>[n + 1];
    while (--n)
    {
        int parent, child, weight;
        std::cin >> parent >> child >> weight;
        edges[parent].push_back({child, weight});
    }

    int w = search(1);
    std::cout << (max > w ? max : w);

    delete[] edges;
}