#include <stdio.h>
#include <string.h>

int main() {
    char a[64], b[64];
    scanf("%s%s", a, b);
    int alen = strlen(a);
    int blen = strlen(b);
    int min = 64;
    for (int i = 0; i <= blen - alen; i++) {
        int diff = 0;
        for (int j = 0; j < alen; j++) {
            diff += a[j] != b[i + j];
        }
        min = diff < min ? diff : min;
    }
    printf("%d", min);
    return 0;
}