#include <iostream>
using namespace std;

int main(){
    int n, m;
    cin >> n >> m;
    cout << (n * 100 < m ? "No" : "Yes");
    
    return 0;
}