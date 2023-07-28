#include <iostream>
using namespace std;

int main()
{
    int Y, M, D, y, m, d;
    cin >> Y >> M >> D >> y >> m >> d;
    cout << (y - Y) - (m > M ? 0 : m == M && d >= D ? 0 : 1) << endl << y - Y + 1 << endl << y - Y;
    return 0;
}