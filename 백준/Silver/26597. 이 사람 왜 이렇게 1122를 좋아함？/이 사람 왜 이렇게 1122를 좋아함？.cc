#include <iostream>
using namespace std;
typedef long long int ll;

int main(){
    int q;
    ll top = 1000000000000000000, bottom = -top, xarr[111223];
    char carr[111223];
    cin >> q;

    for (int i = 1; i <= q; i++){
        ll x;
        char c;
        cin >> x >> c;

        if (c == 'v'){
            top = min(top, x - 1);
        }
        else{
            bottom = max(bottom, x + 1);
        }

        if (bottom > top){
            cout << "Paradox!\n" << i;
            return 0;
        }

        xarr[i] = x;
        carr[i] = c;
    }

    top = 1000000000000000000;
    bottom = -top;

    for (int i = 1; i <= q; i++){
        if (carr[i] == 'v'){
            top = min(top, xarr[i] - 1);
        }
        else{
            bottom = max(bottom, xarr[i] + 1);
        }

        if (bottom == top){
            cout << "I got it!\n" << i;
            return 0;
        }
    }

    cout << "Hmm...";

    return 0;
}