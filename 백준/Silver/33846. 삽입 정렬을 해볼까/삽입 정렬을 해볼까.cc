#include <iostream>
#include <vector>
#include <algorithm>

int main()
{
    std::ios_base::sync_with_stdio(0);
    std::cin.tie(0);
    std::cout.tie(0);

    int n, t, i;
    std::vector<int> a;
    std::cin >> n >> t;
    a.reserve(n);
    while (n-- > 0)
    {
        std::cin >> i;
        a.push_back(i);
    }

    std::sort(a.begin(), a.begin() + t);

    for (const int &a : a)
        std::cout << a << ' ';

    return 0;
}