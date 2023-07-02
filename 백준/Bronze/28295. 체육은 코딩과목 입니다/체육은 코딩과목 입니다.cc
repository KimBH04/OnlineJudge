#include <iostream>

char dir[4] = { 'N', 'E', 'S', 'W' };

int main()
{
	int r = 0;
	for (int i = 0; i < 10; i++)
	{
		int x;
		std::cin >> x;
		r += x;
	}
	std::cout << dir[r % 4];

	return 0;
}