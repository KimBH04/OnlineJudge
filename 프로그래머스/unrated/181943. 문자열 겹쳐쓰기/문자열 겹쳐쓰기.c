#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>
#include <string.h>

char* solution(const char* my_string, const char* overwrite_string, int s) {
    char* r = my_string;
    int l = strlen(overwrite_string);
    for (int i = 0; i < l; i++) {
        r[s + i] = overwrite_string[i];
    }
    return r;
}