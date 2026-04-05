#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;
typedef long long int ll;

int main(){
    cin.tie(NULL);
    cout.tie(NULL);
    ios_base::sync_with_stdio(0);
    
    vector<int> x[11];
    for (int i = 0; i < 2047; i++){
        for (int j = 0; j < 11; j++){
            int a;
            cin >> a;
            x[j].push_back(a);
        }
    }

    for (int i = 0; i < 11; i++){
        sort(x[i].begin(), x[i].end());

        if (x[i][0] == x[i][1023]){
            cout << x[i][2046] << " ";
        }
        else if (x[i][1023] == x[i][2046]){
            cout << x[i][0] << " ";
        }
        
    }



    return 0;
}