#include <stdio.h>
#include <string.h>

int diff(char *a, char *b, int count);

int main() {
    char a[64], b[64];
    scanf("%s%s", a, b);
    int alen = strlen(a);
    int blen = strlen(b);
    int min = 64;
    for (int i = 0; i <= blen - alen; i++) {
        int d = diff(a, b + i, alen);
        min = d < min ? d : min;
    }
    printf("%d", min);
    return 0;
}

int diff(char *a, char *b, int count) {
    int result = 0;
    for (int i = 0; i < count; i++) {
        result += a[i] != b[i];
    }
    return result;
}