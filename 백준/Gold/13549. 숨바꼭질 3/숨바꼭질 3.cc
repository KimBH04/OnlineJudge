#include <iostream>
#include <deque>

int times[100001];

void search(int n, int k) {
    times[n] = 0;
    std::deque<int> deque;
    deque.push_front(n);
    while (deque.size() > 0) {
        int x = deque.front();
        deque.pop_front();

        if (x < 100000 && times[x] + 1 < times[x + 1]) {
            times[x + 1] = times[x] + 1;
            deque.push_back(x + 1);
        }
        if (x > 0 && times[x] + 1 < times[x - 1]) {
            times[x - 1] = times[x] + 1;
            deque.push_back(x - 1);
        }
        if (x < 50001 && times[x] < times[x * 2]) {
            times[x * 2] = times[x];
            deque.push_front(x * 2);
        }
    }
}

int main() {
    int n, k;
    for (int idx = 0; idx < 100001; idx++) {
        times[idx] = 100001;
    }
    std::cin >> n >> k;
    search(n, k);
    std::cout << times[k];
    return 0;
}