#include <iostream>
using namespace std;

int fibonacci[46];

void Fibonacci(){
    fibonacci[0] = fibonacci[1] = 1;
    for (int i = 2; i < 46; i++){
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
    }
}

int main(){
    Fibonacci();

    int n;
    cin >> n;

    while (n--){
        int x;
        cin >> x;

        cout << fibonacci[x] << endl;
    }
    
    return 0;
}