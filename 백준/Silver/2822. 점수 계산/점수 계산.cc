#include <iostream>
#include <algorithm>
using namespace std;

int main(){
    int score[8], sum[8], num[5];
    for (int i = 0; i < 8; i++){
        cin >> score[i];
        sum[i] = score[i];
    }

    sort(sum, sum + 8);
    reverse(sum, sum + 8);
    int total = sum[0] + sum[1] + sum[2] + sum[3] + sum[4];

    for (int i = 0; i < 5; i++){
        for (int j = 0; j < 8; j++){
            if (sum[i] == score[j]){
                num[i] = j + 1;
            }
        }
    }

    sort(num, num + 5);

    cout << total << endl << num[0] << " " << num[1] << " " << num[2] << " " << num[3] << " " << num[4];
    
    return 0;
}