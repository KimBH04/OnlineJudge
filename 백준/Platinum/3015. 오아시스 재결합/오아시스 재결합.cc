#include <iostream>
#include <utility>
#include <stack>

int main() {
    std::ios::sync_with_stdio(0);
    std::cin.tie(0);

    int n, x;
    long long cnt = 0;
    std::cin >> n;
    std::stack<std::pair<int, long long>> stack;
    while (n--) {
        std::cin >> x;
    re:
        if (stack.empty()) {
            stack.push(std::make_pair(x, 0));
        }
        else if (stack.top().first > x) {
            stack.push(std::make_pair(x, 1));
            cnt++;
        }
        else if (stack.top().first < x) {
            cnt += stack.top().second;
            stack.pop();
            if (stack.empty()) {
                cnt++;
            }
            goto re;
        }
        else /* (stack.top().first == x) */ {
            long long *top = &stack.top().second;
            cnt += ++(*top);
        }
    }
    std::cout << cnt;
}