#include <iostream>

int main() {
    std::ios::sync_with_stdio(0);
    std::cin.tie(0);
    std::cout.tie(0);

    int n, x;
    bool appear[2000001] { false };
    std::cin >> n;
    while (n--) {
        std::cin >> x;
        appear[x + 1000000] = true;
    }

    for (int idx = 2000000; idx >= 0; idx--) {
        if (appear[idx]) {
            std::cout << idx - 1000000 << '\n';
        }
    }

    return 0;
}