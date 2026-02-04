from math import log10, pi, e

def stirling(n: int):
    return log10(2 * pi * n) * 0.5 + log10(n / e) * n

n = int(input())
while n > 0:
    m = int(input())
    print(int(stirling(m)) + 1)
    n -= 1