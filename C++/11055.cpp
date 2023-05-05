#include <iostream>

using namespace std;

int main()
{
	int n = 0, a[1001]{ 0 }, d[1001]{ 0 };
	a[0] = d[0] = 0;

	cin >> n;
	for (int i = 1; i <= n; i++) {
		cin >> a[i];
		d[i] = a[i];
	}

	int max = 0;
	for (int i = 1; i <= n; i++){
		for (int j = 0; j < i; j++){
			if (a[j] < a[i] && d[i] < d[j] + a[i]){
				d[i] = d[j] + a[i];
			}
		}

		if (max < d[i]){
			max = d[i];
		}
	}

	cout << max;
	return 0;
}
