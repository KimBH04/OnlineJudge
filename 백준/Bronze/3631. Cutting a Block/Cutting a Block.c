#include <stdio.h>
typedef double f64;

int main()
{
    f64 x;
    int y, z, n;
    scanf("%lf%d%d%d", &x, &y, &z, &n);

    f64 x1 = 0.0;
    for (int i = 1; i <= n; i++)
    {
        printf("%.9lf %d %d ", x1, 0, 0);
        printf("%.9lf %d %d\n", x1 = i * x / n, y, z);
    }
    return 0;
}