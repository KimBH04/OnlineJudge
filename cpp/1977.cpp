#include <iostream>

using namespace std;

int main(){
    int m, n;
    cin >> m >> n;

    int min = 10001, sum = 0;
    for (int i = 1; i * i <= n; i++){
        int ii = i * i;
        if (ii >= m && ii <= n){
            if (min > ii){
                min = ii;
            }

            sum += ii;
        }
    }

    if (sum > 0){
        cout << sum << endl << min;
    }
    else{
        cout << -1;
    }

    return 0;
}