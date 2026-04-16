#include <iostream>
#include <string>
using namespace std;

int main(){
    int n, m;
    string r;
    cin >> n >> m;

    for (int i = 0; i < n; i++){
        r += to_string(n);
    }

    for (char c : r){
        if (m--){
            cout << c;
        }
        else{
            break;
        }
    }

    return 0;
}