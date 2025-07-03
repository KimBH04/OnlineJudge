#include <iostream>
#include <string>
#include <queue>

#define P 10'000'000ULL
typedef unsigned long long int ulli;

int main()
{
	std::ios::sync_with_stdio(false);
	std::cin.tie(nullptr);

    unsigned int n;
	std::cin >> n;
	if (n == 0 || n == 1)
	{
		std::cout << '1';
		return 0;
	}

	std::priority_queue<std::pair<int, ulli*>> pq;
	for (unsigned int i = 2; i <= n; i++)
	{
		ulli* digits = new ulli[1]{ i };
		pq.push({ -1, digits });
	}

	while (pq.size() > 1)
	{
		std::pair<int, ulli*> a = pq.top(); pq.pop();
		std::pair<int, ulli*> b = pq.top(); pq.pop();

		int a_len = -a.first;
		int b_len = -b.first;
		int result_len = a_len + b_len;
		ulli* a_digits = a.second;
		ulli* b_digits = b.second;
		ulli* result = new ulli[result_len]{ 0 };

		for (int i = 0; i < a_len; i++)
		{
			for (int j = 0; j < b_len; j++)
			{
				result[i + j] += a_digits[i] * b_digits[j];
			}
		}

		for (int i = 0; i < result_len - 1; i++)
		{
			result[i + 1] += result[i] / P;
			result[i] %= P;
		}

		pq.push({ -(result_len - (result[result_len - 1] == 0)), result });
		delete[] a_digits;
		delete[] b_digits;
	}

	std::pair<int, ulli*> f = pq.top();
	int f_len = -f.first;
	ulli* f_digit = f.second;
	std::reverse(f_digit, f_digit + f_len);


	char buf[8];
	std::string str = std::to_string(f_digit[0]);
	for (int i = 1; i < f_len; i++)
	{
		snprintf(buf, sizeof(buf), "%07llu", f_digit[i]);
		str += buf;
	}
	std::cout << str;

	delete[] f_digit;
	return 0;
}