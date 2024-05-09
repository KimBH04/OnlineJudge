#include <stdio.h>
#include <math.h>

int main() {
    int a, b, c;
    scanf("%d%d%d", &a, &b, &c);
    printf("%d", c ? c * c - (a + b) : (int)(sqrt(a + b) + 0.5));
    return 0;
}