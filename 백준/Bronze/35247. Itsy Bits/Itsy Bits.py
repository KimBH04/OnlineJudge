from math import log2 as l
n = int(input())
print(f'{2 ** int(l(l(n)) + 1)} bits' if n > 1 else '1 bit')