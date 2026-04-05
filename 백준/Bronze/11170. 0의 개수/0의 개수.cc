#include <iostream>
using namespace std;

int main(){
    int t;
    cin >> t;
    while (t--){
        int n, m, r = 0;
        cin >> n >> m;
        for (int i = n; i <= m; i++){
            n = i;
            do{
                if (n % 10 == 0){
                    r++;
                }
                n /= 10;
            }while (n);
        }

        cout << r << endl;
    }
}