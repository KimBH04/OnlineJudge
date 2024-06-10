#include <stdio.h>

typedef struct log {
    int t, a, b;
} log;

static inline void sort(log *logs, int count) {
    for (int i = 1; i < count; i++) {
        for (int j = 0; j < count - i; j++) {
            if (logs[j].t > logs[j + 1].t) {
                log temp = logs[j];
                logs[j] = logs[j + 1];
                logs[j + 1] = temp;
            }
        }
    }
}

static inline int check(int *infected, int *temp, int start, int end) {
    for (int i = start; i < end; i++) {
        if (infected[i] ^ temp[i]) {
            return 0;
        }
    }
    return 1;
}

int main() {
    int n, m, k, infected[1024] = { 0, }, infected_numbers[1024];
    scanf("%d%d%d", &n, &m, &k);
    for (int i = 0; i < k; i++) {
        scanf("%d", infected_numbers + i);
        infected[infected_numbers[i]] = 1;
    }
    log logs[16384];
    for (int i = 0; i < m; i++) {
        scanf("%d%d%d", &logs[i].t, &logs[i].a, &logs[i].b);
    }
    sort(logs, m);
    for (int i = 0; i < k; i++) {
        int infected_temp[1024] = { 0, };
        infected_temp[infected_numbers[i]] = 1;
        for (int j = 0; j < m; j++) {
            infected_temp[logs[j].b] |= infected_temp[logs[j].a];
        }
        if (check(infected, infected_temp, 1, n + 1)) {
            printf("%d", infected_numbers[i]);
            break;
        }
    }
    return 0;
}