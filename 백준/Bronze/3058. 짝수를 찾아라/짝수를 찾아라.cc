#include <iostream>

int main(){
    int t;
    std::cin >> t;

    while (t--){
        int r = 0, min = 100;
        for (int i = 0; i < 7; i++){
            int n;
            std::cin >> n;
            if (!(n % 2)){
                r += n;
                min = std::min(min, n);
            }
        }
        std::cout << r << " " << min << "\n";
    }

    return 0;
}