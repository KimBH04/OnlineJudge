#include <iostream>
#include <vector>
using namespace std;

int main(){
    vector<int> v;
    int n, r = 0, m = 0;
    cin >> n;

    for (int i = 0; i < n; i++){
        int a;
        cin >> a;
        v.push_back(a);
    }

    while (n--){
        if (m < v[n]){
            m = v[n];
            r++;
        }
    }

    cout << r;

    return 0;
}