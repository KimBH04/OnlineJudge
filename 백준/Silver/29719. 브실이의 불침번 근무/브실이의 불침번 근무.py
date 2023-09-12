n, m = map(int, input().split())
print((m ** n - (m - 1) ** n) % 1000000007)