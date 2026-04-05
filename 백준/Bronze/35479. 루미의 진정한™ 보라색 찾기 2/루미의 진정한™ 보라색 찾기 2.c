#include <stdio.h>

int main()
{
    double r, g, b;
    scanf("%lf%lf%lf", &r, &g, &b);
    double R = r / 255, G = g / 255, B = b / 255;
    double m = R > G ? R : G;
    if (m < B) m = B;
    double K = 1 - m;
    if (K == 1)
    {
        printf("0 0 0 1");
        return 0;
    }
    double C = (1 - R - K) / (1 - K), M = (1 - G - K) / (1 - K), Y = (1 - B - K) / (1 - K);
    printf("%lf %lf %lf %lf", C, M, Y, K);
    return 0;
}