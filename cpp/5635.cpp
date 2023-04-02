#include <iostream>
#include <string>
using namespace std;

int main(){
    int n;
    cin >> n;

    string lower, higher;
    int lowerBirth = 0, higherBirth = 20101231;
    while (n--){
        string name;
        int year, mon, day;

        cin >> name >> day >> mon >> year;
        if (lowerBirth < day + mon * 100 + year * 10000){
            lowerBirth = day + mon * 100 + year * 10000;
            lower = name;
        }
        if (higherBirth > day + mon * 100 + year * 10000){
            higherBirth = day + mon * 100 + year * 10000;
            higher = name;
        }
    }
    
    cout << lower << endl << higher;

    return 0;
}