#include <stdio.h>
#include <string.h>

int main() {
    int n, cnt = 0;
    char s[11], r[11];
    scanf("%s%d", s, &n);
    while (n--) {
        scanf("%s", r);
        if (strncmp(s, r, 5) == 0) {
            cnt++;
        }
    }
    printf("%d", cnt);
    return 0;
}