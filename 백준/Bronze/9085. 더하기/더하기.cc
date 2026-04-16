#include <iostream>
using namespace std;

int main()
{
    int t;
    cin >> t;
    while (t--){
        int n, r = 0;
        cin >> n;
        while (n--){
            int a;
            cin >> a;
            r += a;
        }
        cout << r << endl;
    }
    return 0;
}
