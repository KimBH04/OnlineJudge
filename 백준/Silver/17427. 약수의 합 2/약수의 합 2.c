#include <stdio.h>

int main() {
    long long int n, sum = 0L;
    scanf("%lld", &n);
    for (long long int i = 1L; i <= n; i++) {
        sum += n - n % i;
    }
    printf("%lld", sum);
    return 0;
}