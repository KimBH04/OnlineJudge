#include <iostream>
#include <list>
using namespace std;
typedef long long int ll;

int main(){
    cout.tie(0);
    ios_base::sync_with_stdio(NULL);

    ll a, b;
    cin >> a >> b;
    
    if (a > b){
        ll temp = a;
        a = b;
        b = temp;
    }

    list<ll> ls;
    for (ll i = a + 1; i < b; i++){
        ls.push_back(i);
    }

    cout << ls.size() << "\n";
    for (ll item : ls){
        cout << item << " ";
    }
    
    return 0;
}