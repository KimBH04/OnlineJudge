#include <iostream>

int main() {
    int n, k;
    std::cin >> n >> k;

    int result = 0;
    for (int h = 0; h <= n; h++) {
        for (int m = 0; m < 60; m++) {
            for (int s = 0; s < 60; s++) {
                if (h / 10 == k || h % 10 == k || m / 10 == k || m % 10 == k || s % 10 == k || s / 10 == k) {
                    result++;
                }
            }
        }
    }

    std::cout << result;
}