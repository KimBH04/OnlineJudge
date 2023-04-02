#include <iostream>
using namespace std;

int main(){
    int n, a[1000001]{ 0 }, d[1000001]{ 0 };
    cin >> n;

    int max = 0;
    for (int i = 1; i <= n; i++){
        cin >> a[i];
        d[i] = 0;
        for (int j = 0; j < i; j++){
            if (a[j] < a[i] && d[j] >= d[i]){
                d[i] = d[j] + 1;
            }
        }

        if (max < d[i])
            max = d[i];
    }

    cout << max;
    
    return 0;
}