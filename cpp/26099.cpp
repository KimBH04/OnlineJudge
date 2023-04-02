#include <iostream>
using namespace std;
typedef long long ll;

ll Sugar(ll n);

int main(){
    ll n;
    cin >> n;
    cout << Sugar(n);
    return 0;
}

ll Sugar(ll n){
    for (int i = 0; n - 3 * i >= 0; i++){
        if ((n - 3 * i) % 5 == 0){
            return i + (n - 3 * i) / 5;
        }
    }

    return -1;
}