#include <iostream>

int main()
{
    int p;
    std::cin >> p;
    while (p--)
    {
        long n, m;
        std::cin >> n >> m;
        long a = 0, b = 1;
        for (long i = 1; i <= m * m; i++)
        {
            long temp = a + b;
            a = b;
            b = temp % m;

            if (a == 0 && b == 1)
            {
                std::cout << n << ' ' << i << '\n';
                break;
            }
        }
    }
    return 0;
}