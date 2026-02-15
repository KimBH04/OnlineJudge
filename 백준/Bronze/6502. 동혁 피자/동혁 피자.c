#include <stdio.h>

int main()
{
    int r, w, l;
    for (int i = 1; scanf("%d", &r) && (r *= 2); i++)
    {
        scanf("%d%d", &w, &l);
        printf("Pizza %d %s\n", i, (w * w + l * l > r * r ? "does not fit on the table." : "fits on the table."));
    }
    return 0;
}