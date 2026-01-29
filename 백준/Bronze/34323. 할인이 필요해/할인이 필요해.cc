#include <iostream>

int main()
{
    long n, m, s;
    std::cin >> n >> m >> s;
    std::cout << std::min((m * s + s) * (100 - n) / 100, m * s);
    return 0;
}