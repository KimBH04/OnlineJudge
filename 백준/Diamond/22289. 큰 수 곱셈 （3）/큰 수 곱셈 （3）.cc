#include <iostream>
#include <string>
#include <vector>
#include <complex>

using idouble = std::complex<double>;

idouble *a, *b;
unsigned long size = 1;
const double PI = std::acos(-1);

void fft(idouble *f, bool inv)
{
    for (int i = 1, j = 0; i < size; i++)
    {
        int bit = size >> 1;
        for (; j & bit; bit >>= 1) 
            j ^= bit;
        j ^= bit;
        if (i < j)
            std::swap(f[i], f[j]);
    }

    for (int len = 2; len <= size; len <<= 1)
    {
        double ang = 2 * PI / len * (inv ? -1 : 1);
        idouble wlen(std::cos(ang), std::sin(ang));
        for (int i = 0; i < size; i += len)
        {
            idouble w(1);
            for (int j = 0; j < len >> 1; j++)
            {
                idouble u = f[i + j], v = f[i + j + (len >> 1)] * w;
                f[i + j             ] = u + v;
                f[i + j + (len >> 1)] = u - v;
                w *= wlen;
            }
        }
    }

    if (inv)
    {
        for (int i = 0; i < size; i++)
            f[i] /= size;
    }
}

void solve()
{
    fft(a, false);
    fft(b, false);

    for (int i = 0; i < size; i++)
        a[i] *= b[i];

    fft(a, true);

    std::vector<int> result(size);
    for (int i = 0; i < size; i++)
        result[i] = (int)std::round(a[i].real());

    for (int i = 0; i < size - 1; i++)
    {
        result[i + 1] += result[i] / 10;
        result[i] %= 10;
    }

    int i = size - 1;
    while (i > 0 && result[i] == 0)
        i--;
    for (; i >= 0; i--)
        std::cout << result[i];
    std::cout << std::endl;
}

void input()
{
    std::string A, B;
    std::cin >> A >> B;
    auto alen = A.length();
    auto blen = B.length();
    auto length = alen + blen;
    while (size <= length)
    {
        size <<= 1;
    }
    a = new idouble[size] { 0 };
    b = new idouble[size] { 0 };
    for (int i = 0; i < alen; i++)
    {
        a[i] = A[alen - i - 1] - '0';
    }
    for (int i = 0; i < blen; i++)
    {
        b[i] = B[blen - i - 1] - '0';
    }
}

int main()
{
    input();
    solve();
    delete[] a;
    delete[] b;
    return 0;
}