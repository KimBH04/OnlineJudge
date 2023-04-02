#include <iostream>
using namespace std;

int main(){
    char s[1000000];
    cin >> s;
    
    int madi = 0;
    char now = s[0];
    for (int i = 1; s[i]; i++){
        if (now != s[i]){
            madi++;
            now = s[i];
        }
    }

    cout << madi / 2 + (madi % 2 ? 1 : 0);
    
    return 0;
}