#include <stdio.h>

int gcd(int a, int b)
{
    while (b)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

int main()
{
    int x, m, n = 1;
    scanf("%d %d", &x, &m);
    if (gcd(m, x) != 1)
    {
        printf("No such integer exists.");
        return 0;
    }

    while (x * n % m != 1)
    {
        n++;
    }
    printf("%d", n);
    return 0;
}