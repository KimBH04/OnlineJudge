#include <stdio.h>
#include <string.h>

int main()
{
    while (1)
    {
        char name[11];
        int age, weight;
        scanf("%s %d %d", name, &age, &weight);

        if (!strcmp(name, "#") && age == 0 && weight == 0)
            break;

        printf("%s %snior\n", name, age > 17 || weight > 79 ? "Se" : "Ju");
    }
    return 0;
}