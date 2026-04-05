#include <iostream>
#include <vector>
using namespace std;

int main(){
    cin.tie(NULL);
    cout.tie(NULL);
    ios_base::sync_with_stdio(0);

    int n;
    vector<pair<int, int>> v;

    cin >> n;
    for (int i = 0; i < n; i++){
        int x;
        cin >> x;

        while (!v.empty()){
            if (v.back().second > x){
                cout << v.back().first << " ";
                break;
            }
            else{
                v.pop_back();
            }
        }

        if (v.empty()){
            cout << 0 << " ";
        }

        v.push_back(make_pair(i + 1, x));
    }

    return 0;
}