#include <stdio.h>
#include <string.h>

int main() {
    int max = 0;
    char name[32];
    for (int i = 0; i < 7; i++) {
        int applicant;
        char input[32];
        scanf("%s%d", input, &applicant);
        if (max < applicant) {
            max = applicant;
            strcpy(name, input);
        }
    }
    printf("%s", name);
    return 0;
}