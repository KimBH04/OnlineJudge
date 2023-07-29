#include <stdio.h>

int main()
{
    int n, m;
    scanf("%d %d", &n, &m);
    printf("%sE!", m > n ? "TL" : m > 2 ? "OLDBI" : "NEWBI");
    return 0;
}