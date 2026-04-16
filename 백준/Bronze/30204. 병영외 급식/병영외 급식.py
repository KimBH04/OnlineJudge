n, m = map(int, input().split())
s = sum(map(int, input().split()))
print(0 if s % m else 1)