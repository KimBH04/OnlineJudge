a, b = map(int, input().split())

if a > b:
    temp = b
    b = a
    a = temp

print((a + b) * (b - a + 1) // 2)