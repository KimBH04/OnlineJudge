n = int(input())
sizes = input()
t, p = map(int, input().split())
s = 0
for size in map(int, sizes.split()):
    s += size // t + (size % t > 0)
print(s)
print(n // p, n % p)