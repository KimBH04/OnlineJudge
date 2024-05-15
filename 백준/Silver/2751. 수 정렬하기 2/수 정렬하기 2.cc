#include <iostream>
#include <vector>
#include <algorithm>

int main() {
        int n;
        std::cin >> n;
        std::vector<int> v(n);
        while (n-- > 0) {
                std::cin >> v[n];
        }
        std::sort(v.begin(), v.end());
        for (const auto &x : v) {
                std::cout << x << '\n';
        }
}