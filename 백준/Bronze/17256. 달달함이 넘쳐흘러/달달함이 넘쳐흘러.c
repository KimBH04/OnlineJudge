#include <stdio.h>

typedef struct cake
{
    int x;
    int y;
    int z;
} cake;

int main()
{
    cake a, b, c;
    scanf("%d %d %d %d %d %d", &a.x, &a.y, &a.z, &c.x, &c.y, &c.z);
    b.x = c.x - a.z;
    b.y = c.y / a.y;
    b.z = c.z - a.x;
    printf("%d %d %d", b.x, b.y, b.z);
    return 0;
}