#include <iostream>
using namespace std;

int main(){
    int k;
    cin >> k;

    while (k--)
    {
        int p, m, seat[500], r = 0;
        cin >> p >> m;
        for (int i = 0; i < m; i++){
            seat[i] = 0;
        }

        for (int i = 0; i < p; i++){
            int a;
            cin >> a;
            if (!seat[a - 1]){
                seat[a - 1] = 1;
            }
            else{
                r++;
            }
        }

        cout << r << endl;
    }
    
    return 0;
}