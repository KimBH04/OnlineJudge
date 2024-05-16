#include <stdio.h>
#include <stdlib.h>

int trouble[10] = { 0, };

int is_trouble(int n) {
    do {
        if (trouble[n % 10]) {
            return 1;
        }
    } while (n /= 10);
    return 0;
}

int digit(int n) {
    int re = 0;
    do {
        re++;
    }
    while (n /= 10);
    return re;
}

int main() {
    int n, m, num, min, any;
    scanf("%d%d", &n, &m);
    min = abs(n - 100);
    while (m--) {
        scanf("%d", &any);
        trouble[any] = 1;
    }
    for (num = 0; num < 1000000; num++) {
        if (!is_trouble(num)) {
            any = abs(n - num) + digit(num);
            if (min > any) {
                min = any;
            }
        }
    }
    printf("%d", min);
    return 0;
}