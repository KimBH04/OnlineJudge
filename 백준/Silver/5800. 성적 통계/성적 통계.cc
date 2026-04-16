#include <iostream>
#include <algorithm>
using namespace std;

int main(){
    int k;
    cin >> k;
    
    for (int i = 1; i <= k; i++){
        int n, c[50], gap = 0;
        cin >> n;

        for (int i = 0; i < n; i++){
            cin >> c[i];
        }

        sort(c, c + n);

        for (int i = 1; i < n; i++){
            gap = max(gap, c[i] - c[i - 1]);
        }

        cout << "Class " << i << "\nMax " << c[n - 1] << ", Min " << c[0] << ", Largest gap " << gap << "\n";
    }
    
    return 0;
}