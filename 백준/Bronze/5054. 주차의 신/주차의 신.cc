#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main(){
    int t;
    cin >> t;

    while (t--){
        int n;
        cin >> n;
        vector<int> shop;
        while (n--){
            int a;
            cin >> a;
            shop.push_back(a);
        }
        
        int max = *max_element(shop.begin(), shop.end());
        int min = *min_element(shop.begin(), shop.end());
        cout << (max - min) * 2 << endl;
    }
    return 0;
}