#include <iostream>
#include <queue>
using namespace std;

int main(){
    int h, v, map[100][100];
    cin >> v >> h;

    for (int i = 0; i < v; i++){
        for (int j = 0; j < h; j++){
            cin >> map[i][j];
        }
    }

    queue<int[]> q;
    q.push({0, 0});
    
    while (!q.empty()){
        int *a;
        a = q.front();
        q.pop();

        if (a[0] - 1 >= 0){
            if (a[1] - 1 >= 0){

            }
        }
    }
    
    return 0;
}