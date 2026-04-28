#include <string>
#include <vector>

using namespace std;

void solve(vector<vector<int>> &triangle, int m, int depth) {
    if (m <= depth + 1) {
        return;
    }
    solve(triangle, m, depth + 1);
    
    int len = triangle[depth].size();
    for (int i = 0; i < len; i++) {
        triangle[depth][i] += max(triangle[depth + 1][i], triangle[depth + 1][i + 1]);
    }
}

int solution(vector<vector<int>> triangle) {
    solve(triangle, triangle.size(), 0);
    return triangle[0][0];
}