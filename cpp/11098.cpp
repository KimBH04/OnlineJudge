#include <iostream>
#include <string>
using namespace std;

int main(){
    int n;
    cin >> n;

    while (n-- > 0){
        int price = 0, p;
        string premium;

        cin >> p;
        while (p-- > 0){
            int pr;
            string pre;
            
            cin >> pr >> pre;
            if (price < pr){
                price = pr;
                premium = pre;
            }
        }

        cout << premium << endl;
    }

    return 0;
}