#include <iostream>
#include <algorithm>
using namespace std;

int main(){
    int t, arr[5];
    cin >> t;

    while (t--){
        for (int i = 0; i < 5; i++){
            cin >> arr[i];
        }

        sort(arr, arr + 5);
        if (arr[3] - arr[1] < 4){
            int r = 0;
            for (int i = 1; i < 4; i++){
                r += arr[i];
            }
            cout << r << "\n";
        }
        else{
            cout << "KIN\n";
        }
    }
    
    return 0;
}