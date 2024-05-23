#include <iostream>
#include <vector>

int main() {
    int n;
    std::cin >> n;
    std::vector<std::pair<int, int>> dp(n + 1);
    for (int i = 1; i < n; i++) {
        int a = i + 1, b = i * 2, c = i * 3, d = dp[i].first + 1;
        if (a <= n && (!dp[a].first || dp[a].first > d)) {
            dp[a].first = d;
            dp[a].second = i;
        }
        if (b <= n && (!dp[b].first || dp[b].first > d)) {
            dp[b].first = d;
            dp[b].second = i;
        }
        if (c <= n && (!dp[c].first || dp[c].first > d)) {
            dp[c].first = d;
            dp[c].second = i;
        }
    }
    std::cout << dp[n].first << '\n';
    while (n) {
        std::cout << n << ' ';
        n = dp[n].second;
    }
}