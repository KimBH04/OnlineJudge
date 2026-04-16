#include <iostream>
using namespace std;

int main(){
    int r = 0;
    char s[100];
    cin >> s;
    for (char c : s){
        
        if (!c)
            break;

        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            r++;
    }

    cout << r;
    
    return 0;
}