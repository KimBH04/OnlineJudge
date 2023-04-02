#include <algorithm>
#include <iostream>
#include <vector>
#include <queue>
using namespace std;

static bool visited[1001];
static vector<int> node[1001];

void DFS(int v);
void BFS(int v);

int main(){
    int n, m, v;
    cin >> n >> m >> v;

    for (int i = 0; i < m; i++){
        int s, e;
        cin >> s >> e;
        node[s].push_back(e);
        node[e].push_back(s);
    }

    for (int i = 1; i <= n; i++){
        sort(node[i].begin(), node[i].end());
    }

    visited[v] = true;
    DFS(v);
    cout << endl;
    
    for (int i = 1; i <= n; i++){
        visited[i] = false;
    }
    visited[v] = true;
    BFS(v);

    return 0;
}

void DFS(int v){
    cout << v << " ";
    int size = node[v].size();
    for (int i = 0; i < size; i++){
        if (visited[node[v][i]])
            continue;

        visited[node[v][i]] = true;
        DFS(node[v][i]);
    }
}

void BFS(int v){
    queue<int> q;
    q.push(v);
    while (q.size()){
        int n = q.front();
        q.pop();
        cout << n << " ";

        int size = node[n].size();
        for (int i = 0; i < size; i++){
            if (visited[node[n][i]])
                continue;

            visited[node[n][i]] = true;
            q.push(node[n][i]);
        }   
    }
}