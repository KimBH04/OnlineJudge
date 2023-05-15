#include <stdio.h>

int _gcd(int a, int b)
{
    if (a < b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    while (b)
    {
        int r = a % b;
        a = b;
        b = r;
    }

    return a;
}

int main()
{
    int a1, b1, a2, b2;
    scanf("%d %d", &a1, &b1);
    scanf("%d %d", &a2, &b2);

    int a = (a1 * b2) + (a2 * b1), b = b1 * b2;

    int gcd = _gcd(a, b);

    printf("%d %d", a / gcd, b / gcd);

    return 0;
}