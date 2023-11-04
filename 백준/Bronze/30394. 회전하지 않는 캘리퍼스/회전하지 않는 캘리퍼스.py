n = int(input())
a, b = 10 ** 9, -(10 ** 9)
while n:
    n -= 1
    x, y = map(int, input().split())
    a = min(a, y)
    b = max(b, y)
print(b - a)