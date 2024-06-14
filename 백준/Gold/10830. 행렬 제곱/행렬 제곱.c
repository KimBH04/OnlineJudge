#include <stdio.h>
#include <string.h>
#define MOD 1000

int a[5][5], multi_result[5][5], power_result[5][5];

void copy(const int n, int (*to)[5], const int (*from)[5]) {
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            to[i][j] = from[i][j];
        }
    }
}

void multi(const int n, const int (*a)[5], const int (*b)[5]) {
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            multi_result[i][j] = 0;
            for (int k = 0; k < n; k++) {
                multi_result[i][j] %= MOD;
                multi_result[i][j] += a[i][k] % MOD * (b[k][j] % MOD) % MOD;
                multi_result[i][j] %= MOD;
            }
        }
    }
}

void power(const int n, long long int pow) {
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            power_result[i][j] = i == j;
        }
    }

    while (pow > 0) {
        if (pow % 2) {
            multi(n, power_result, a);
            copy(n, power_result, multi_result);
        }
        multi(n, a, a);
        copy(n, a, multi_result);
        pow /= 2;
    }
}

int main() {
    int n;
    long long int b;
    scanf("%d%lld", &n, &b);
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            scanf("%d", a[i] + j);;
        }
    }
    power(n, b);
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            printf("%d ", power_result[i][j]);
        }
        printf("\n");
    }
    return 0;
}