#include <stdio.h>
#include <stdlib.h>

int* solution(int e, int starts[], size_t starts_len) {
    int *data = (int*)malloc(sizeof(int) * (e + 1));
    memset(data, 0, sizeof(int) * (e + 1));
    
    for (int i = 1; i <= e; i++) {
        for (int j = 1; i >= j && i * j <= e; j++) {
            data[i * j] += i == j ? 1 : 2;
        }
    }
    
    int *suf = (int*)malloc(sizeof(int) * (e + 1));
    suf[e] = e;
    for (int i = e - 1; i > 0; i--) {
        suf[i] = data[i] >= data[suf[i + 1]] ? i : suf[i + 1];
    }
    
    int *answer = (int*)malloc(sizeof(int) * starts_len);
    for (size_t i = 0; i < starts_len; i++) {
        answer[i] = suf[starts[i]];
    }
    free(data);
    free(suf);
    return answer;
}