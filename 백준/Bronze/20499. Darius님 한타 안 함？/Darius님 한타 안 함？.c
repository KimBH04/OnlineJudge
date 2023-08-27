#include <stdio.h>

int main()
{
    int k, d, a;
    scanf("%d/%d/%d", &k, &d, &a);
    printf("%ssu", k + a < d || d == 0 ? "ha" : "go");
    return 0;
}