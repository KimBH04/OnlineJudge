#include <iostream>
#include <string.h>
#include <queue>
#include <assert.h>

int n, m, k;
bool map[1001][1001], visited[11][1001][1001];
const std::pair<int, int> DIR[4] = {{1, 0}, {-1, 0}, {0, 1}, {0, -1}};

inline int search() {
    visited[k][1][1] = true;
    std::queue<std::pair<int, std::pair<int, int>>> queue;
    queue.push({k, {1, 1}});

    for (int cnt = 1, size, remain, r, c, row, col; size = queue.size(); cnt++) {
        while (size--) {
            remain = queue.front().first;
            r = queue.front().second.first;
            c = queue.front().second.second;
            queue.pop();
            if (r == n && c == m) {
                return cnt;
            }

            for (const auto &dir : DIR) {
                row = r + dir.first;
                col = c + dir.second;
                if (0 < row && row <= n && 0 < col && col <= m) {
                    if (!map[row][col]) {
                        if (!visited[remain][row][col]) {
                            visited[remain][row][col] = true;
                            queue.push({remain, {row, col}});
                        }
                    }
                    else if (cnt % 2 && remain > 0) {   //morning
                        if (!visited[remain - 1][row][col]) {
                            visited[remain - 1][row][col] = true;
                            queue.push({remain - 1, {row, col}});
                        }
                    }
                }
            }
            if (cnt % 2 == 0) {
                queue.push({remain, {r, c}});
            }
        }
    }
    return -1;
}

inline void set() {
    char input[1001];
    std::cin >> n >> m >> k;
    for (int r = 1; r <= n; r++) {
        std::cin >> input;
        assert(strlen(input) == m);
        for (int c = 1; c <= m; c++) {
            map[r][c] = input[c - 1] == '1';
            for (int remain = 0; remain <= k; remain++) {
                visited[remain][r][c] = false;
            }
        }
    }
}

int main() {
    set();
    std::cout << search();
    return 0;
}