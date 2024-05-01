#include <iostream>
#include <string>
#include <algorithm>

int main() {
    std::string s[3];
    std::cin >> s[0] >> s[1] >> s[2];
    std::sort(s, s + 3);
    std::cout << (s[0][0] == 'k' && s[1][0] == 'l' && s[2][0] == 'p' ? "GLOBAL" : "PONIX");
    return 0;
}