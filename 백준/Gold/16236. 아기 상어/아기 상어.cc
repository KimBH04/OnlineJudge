#include <iostream>
#include <queue>

const std::pair<int, int> DIR[] = {{-1, 0}, {0, -1}, {0, 1}, {1, 0}};
int n, map[32][32], size = 2;

inline bool search(const std::pair<int, int> &start, const std::pair<int, int> &end, int &steps) {
    bool visited[32][32];
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            visited[i][j] = false;
        }
    }
    visited[start.first][start.second] = true;
    std::queue<std::pair<int, int>> q;
    q.push(start);
    steps = 0;
    while (!q.empty()) {
        int q_size = q.size();
        while (q_size-- > 0) {
            int r = q.front().first;
            int c = q.front().second;
            q.pop();
            if (r == end.first && c == end.second) {
                return true;
            }
            for (const auto &dir: DIR) {
                int tr = r + dir.first;
                int tc = c + dir.second;
                if (0 <= tr && tr < n && 0 <= tc && tc < n && !visited[tr][tc] && map[tr][tc] <= size) {
                    visited[tr][tc] = true;
                    q.push({tr, tc});
                }
            }
        }
        steps++;
    }
    return false;
}

int main() {
    std::pair<int, int> start;
    std::cin >> n;
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            std::cin >> map[i][j];
            if (map[i][j] == 9) {
                map[i][j] = 0;
                start = {i, j};
            }
        }
    }
    int total = 0, ate_cnt = 0;
    for (;;) {
        bool ate = false;
        int min_dis = INT32_MAX;
        std::pair<int, int> next = {-1, -1};
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (0 < map[i][j] && map[i][j] < size) {
                    int steps;
                    if (search(start, {i, j}, steps)) {
                        ate = true;
                        if (min_dis > steps) {
                            min_dis = steps;
                            next = {i, j};
                        }
                    }
                }
            }
        }
        if (ate) {
            if (++ate_cnt == size) {
                size++;
                ate_cnt = 0;
            }
            total += min_dis;
            start = next;
            map[next.first][next.second] = 0;
        }
        else {
            break;
        }
    }
    std::cout << total;
}