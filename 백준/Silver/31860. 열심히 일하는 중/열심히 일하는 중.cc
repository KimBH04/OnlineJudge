#include <iostream>
#include <queue>

int main() {
    int n, m, k, d, s = 0, count = 0;
    std::priority_queue<int> pq;
    std::cin >> n >> m >> k;
    while (n--) {
        std::cin >> d;
        pq.push(d);
    }
    std::queue<int> results;
    while (pq.size()) {
        int work = pq.top(); pq.pop();
        d = work - m;
        if (d > k) {
            pq.push(d);
        }
        results.push(s = s / 2 + work);
    }
    std::cout << results.size() << '\n';
    while (results.size()) {
        std::cout << results.front() << '\n';
        results.pop();
    }
}