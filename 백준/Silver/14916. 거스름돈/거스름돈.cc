#include <iostream>
using namespace std;

int moduler(int n){
    for (int i = 0; i * 2 <= n; i++){
        if ((n - 2 * i) % 5 == 0){
            return i + (n - 2 * i) / 5;
        }
    }

    return -1;
}

int main(){
    int n;
    cin >> n;
    cout << moduler(n);
    
    return 0;
}