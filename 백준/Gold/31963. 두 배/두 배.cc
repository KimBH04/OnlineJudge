#include <iostream>
#include <cmath>

typedef unsigned long long ull;

int n;
ull *a;
double *d;

void solve()
{
    ull cnt = 0;
    for (int i = 1; i < n; i++)
    {
        if (a[i - 1] < a[i])
            continue;

        ull diff = a[i - 1] - a[i] + (d[i - 1] > d[i]);
        cnt += diff;
        a[i] += diff;
    }
    std::cout << cnt << std::endl;
}

int main()
{
    std::cin >> n;
    a = new ull[n];
    d = new double[n];

    for (int i = 0; i < n; i++)
    {
        scanf("%llu", a + i);
        auto log = log2(a[i]);
        a[i] = (int)log;
        d[i] = log - a[i];
    }

    solve();

    delete[] a;
    delete[] d;
    return 0;
}