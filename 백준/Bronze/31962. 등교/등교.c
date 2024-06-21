#include <stdio.h>

int main() {
    int n, x, max = -1;
    scanf("%d%d", &n, &x);
    while (n--) {
        int s, t;
        scanf("%d%d", &s, &t);
        if (s + t <= x && max < s) {
            max = s;
        }
    }
    printf("%d", max);
    return 0;
}