#include <iostream>
#include <vector>
using namespace std;

int main(){
    int n, u, d;
    vector<int> geori;
    vector<char> r;

    cin >> n;
    for (int i = 0; i < n; i++){
        int a;
        cin >> a;
        geori.push_back(a);
        r.push_back('\0');
    }
    cin >> u >> d;

    for (int i = 0; i < n; i++){
        if (geori[i] == 1 && u){
            r[i] = 'U';
            u--;
        }
        else if (geori[i] == 2 && d)
        {
            r[i] = 'D';
            d--;
        }
    }

    for (int i = 0; i < n; i++){
        if (geori[i] == 3){
            if (u){
                r[i] = 'U';
                u--;
            }
            else if (d)
            {
                r[i] = 'D';
                d--;
            }
        }
    }

    if (u + d){
        cout << "NO";
    }
    else{
        cout << "YES" << endl;
        for (int i = 0; i < n; i++){
            cout << r[i];
        }
    }

    return 0;
}