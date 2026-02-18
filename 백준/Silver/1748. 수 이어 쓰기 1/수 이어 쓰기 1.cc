#include <iostream>
#include <math.h>

int main()
{
    int n;
    std::cin >> n;
    int l = (int)log10(n);
    long long r = 0;
    long long a = 10, b = 0;
    for (int i = 1; i <= l; i++)
    {
        r += i * (a - b);
        b = a;
        a = b * 10;
    }
    std::cout << r + (n - b + 1) * (l + 1) - 1;
    return 0;
}