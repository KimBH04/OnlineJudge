#include <iostream>
#include <queue>

const std::pair<int, int> DIR[] = {{0, 1}, {0, -1}, {1, 0}, {-1, 0}};

int n, m, map[1024][1024], visited[1024][1024], wall_visited[1024][1024];

inline void set();
inline void search(const int &r, const int &c);

int main() {
    set();
    for (int r = 1; r <= n; r++) {
        for (int c = 1; c <= m; c++) {
            if (!map[r][c] && !visited[r][c]) {
                visited[r][c] = true;
                search(r, c);
            }
        }
    }

    for (int r = 1; r <= n; r++) {
        for (int c = 1; c <= m; c++) {
            std::cout << map[r][c] % 10;
        }
        std::cout << '\n';
    }
}

inline void set() {
    std::cin >> n >> m;
    char input[1024];
    for (int r = 1; r <= n; r++) {
        std::cin >> input + 1;
        for (int c = 1; c <= m; c++) {
            map[r][c] = input[c] - 48;
        }
    }
}

inline void search(const int &r, const int &c) {
    std::queue<std::pair<int, int>> queue, wall_queue;
    queue.push({r, c});
    int cnt = 0, row, col, tr, tc;
    while (!queue.empty()) {
        row = queue.front().first;
        col = queue.front().second;
        queue.pop();

        for (const auto &dir : DIR) {
            tr = row + dir.first;
            tc = col + dir.second;

            if (0 < tr && tr <= n && 0 < tc && tc <= m) {
                if (!map[tr][tc]) {
                    if (!visited[tr][tc]) {
                        visited[tr][tc] = true;
                        queue.push({tr, tc});
                    }
                }
                else {
                    if (!wall_visited[tr][tc]) {
                        wall_visited[tr][tc] = true;
                        wall_queue.push({tr, tc});
                    }
                }
            }
        }
        cnt++;
    }

    while (!wall_queue.empty()) {
        row = wall_queue.front().first;
        col = wall_queue.front().second;
        wall_queue.pop();

        map[row][col] += cnt;
        wall_visited[row][col] = false;
    }
}