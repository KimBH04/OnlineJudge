#include <iostream>
using namespace std;
typedef long long int ll;

int main(){
    int r = 0;
    ll n, cat = 0;
    cin >> n;

    if (n){
        r++;
        cat = 1;
        
        while (cat < n){
            cat *= 2;
            r++;
        }
    }

    cout << r;

    return 0;
}