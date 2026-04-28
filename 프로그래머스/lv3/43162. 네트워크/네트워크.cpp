#include <string>
#include <vector>

using namespace std;

bool *visited;

void search(const int &n, const vector<vector<int>> &edge, const int &v) {
    for (int i = 0; i < n; i++) {
        if (edge[v][i] == 0 || visited[i])
            continue;
        
        visited[i] = 1;
        search(n, edge, i);
    }
}

int solution(int n, vector<vector<int>> computers) {
    visited = new bool[n] { 0 };
    int cnt = 0;
    for (int i = 0; i < n; i++) {
        if (visited[i] == 0) {
            search(n, computers, i);
            cnt++;
        }
    }
    delete[] visited;
    return cnt;
}