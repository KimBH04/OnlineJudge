from decimal import *

n, k = map(int, input().split())
arr = sorted([Decimal(input()) for _ in range(n)])
trimmed = arr[k:-k] if k else arr
adjusted = [trimmed[0]] * k + trimmed + [trimmed[-1]] * k
round = Decimal('1.00')
print((sum(trimmed) / (n - (k + k))).quantize(round, ROUND_HALF_UP))
print((sum(adjusted) / n).quantize(round, ROUND_HALF_UP))