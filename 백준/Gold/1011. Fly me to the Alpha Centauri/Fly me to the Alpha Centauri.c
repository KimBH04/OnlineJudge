#include <stdio.h>

int main()
{
    int t;
    scanf("%d", &t);
    for (int i = 0; i < t; i++)
    {
        int x, y;
        scanf("%d%d", &x, &y);
        int diff = y - x;
        long long int a = 1, b = 1;
        for (int i = 1; a * b < diff || !printf("%d ", i); i++)
        {
            long long int temp = a;
            a = b + 1;
            b = temp;
        }
    }
    return 0;
}