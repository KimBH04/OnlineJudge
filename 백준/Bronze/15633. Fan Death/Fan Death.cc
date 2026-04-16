#include <iostream>
#include <math.h>
using namespace std;

int main(){
    int n, r = 0;

    cin >> n;
    double rootn = sqrt(n);
    for (int i = 1; i <= rootn; i++){
        if (!(n % i)){
            r += i;

            if (i != rootn){
                r += n / i;
            }
        }
    }

    cout << r * 5 - 24;
    
    return 0;
}