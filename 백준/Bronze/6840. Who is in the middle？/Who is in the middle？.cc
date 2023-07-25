#include <iostream>
using namespace std;

void swap(int *a, int *b)
{
    int t = *a;
    *a = *b;
    *b = t;
}

int main()
{
    int a, b, c;
    cin >> a >> b >> c;
    if (a > c)
        swap(&a, &c);

    if (a > b)
        swap(&a, &b);

    if (b > c)
        swap(&b, &c);

    cout << b;
    return 0;
}