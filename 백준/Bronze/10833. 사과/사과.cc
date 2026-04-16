#include <iostream>
using namespace std;

int main(){
    int n, r = 0;
    cin >> n;

    while (n--){
        int a, b;
        cin >> a >> b;

        r += b % a;
    }

    cout << r;
    
    return 0;
}