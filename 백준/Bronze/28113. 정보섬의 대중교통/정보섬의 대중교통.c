#include <stdio.h>

int main()
{
    int n, a, b;
    scanf("%d %d %d", &n, &a, &b);

    if (a < b)
        printf("Bus");
    else if (a > b)
        printf("Subway");
    else
        printf("Anything");

    return 0;
}