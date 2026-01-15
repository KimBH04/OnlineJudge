#include <iostream>
#include <algorithm>
#include <vector>

inline long ccw(std::pair<long, long> a, std::pair<long, long> b, std::pair<long, long> c)
{
    long x1 = b.first - a.first;
    long x2 = c.first - b.first;
    long y1 = b.second - a.second;
    long y2 = c.second - b.second;
    return x1 * y2 - y1 * x2;
}

int main()
{
    int n;
    std::cin >> n;
    std::vector<std::pair<int, int>> dots;
    dots.reserve(n);
    for (int i = 0; i < n; i++)
    {
        int x, y;
        std::cin >> x >> y;
        dots.push_back({x, y});
    }
    std::sort(dots.begin(), dots.end());

    std::vector<std::pair<int, int>> result;
    result.reserve(n * 2);
    for (int i = 0; i < n; i++)
    {
        int s = result.size();
        while (s >= 2 && ccw(result[s - 2], result[s - 1], dots[i]) >= 0)
        {
            result.pop_back();
            s--;
        }
        result.push_back(dots[i]);
    }

    std::reverse(dots.begin(), dots.end());
    std::vector<std::pair<int, int>> result2;
    result2.reserve(n);
    for (int i = 0; i < n; i++)
    {
        int s = result2.size();
        while (s >= 2 && ccw(result2[s - 2], result2[s - 1], dots[i]) >= 0)
        {
            result2.pop_back();
            s--;
        }
        result2.push_back(dots[i]);
    }

    result.insert(result.end(), result2.begin(), result2.end());
    std::sort(result.begin(), result.end());
    result.erase(std::unique(result.begin(), result.end()), result.end());
    std::cout << result.size();

    return 0;
}