#include <iostream>
using namespace std;

int main(){
    int a, b, total;
    cin >> a >> b;
    total = a * b;
    
    while (b){
        cout << b % 10 * a << endl;
        b /= 10;
    }

    cout << total;
    
    return 0;
}