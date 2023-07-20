#include <iostream>
using namespace std;

int main()
{
	int a, b, c;
	cin >> a >> b >> c;
	int d = a + b;
	c *= 2;
	cout << d - (d < c ? 0 : c);
	return 0;
}