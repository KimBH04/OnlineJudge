#include <iostream>
using namespace std;

int main(){
    cin.tie(NULL);
    cout.tie(NULL);
    ios_base::sync_with_stdio(false);

    int t;
    cin >> t;

    while (t--){
        int a, b;
        cin >> a >> b;
        cout << a + b << "\n";
    }
    
    return 0;
}