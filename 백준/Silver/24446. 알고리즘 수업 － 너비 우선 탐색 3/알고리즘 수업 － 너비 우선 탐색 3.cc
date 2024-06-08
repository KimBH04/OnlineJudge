#include <iostream>
#include <queue>
#include <list>
#include <algorithm>

int main() {
    int n, m, r;
    std::cin >> n >> m >> r;
    std::list<int> *edges = new std::list<int>[n + 1];
    while (m--) {
        int u, v;
        std::cin >> u >> v;
        edges[u].push_back(v);
        edges[v].push_back(u);
    }
    int size, depth = 0, *depthes = new int[n + 1];
    std::fill(depthes, depthes + n + 1, -1);
    std::queue<int> q;
    q.push(r);
    while (size = q.size()) {
        while (size--) {
            int node = q.front(); q.pop();
            if (depthes[node] > -1) {
                continue;
            }
            depthes[node] = depth;
            for (const int &child: edges[node]) {
                q.push(child);
            }
        }
        depth++;
    }
    for (int i = 1; i <= n; i++) {
        std::cout << depthes[i] << '\n';
    }
    delete[] edges;
    delete[] depthes;
}