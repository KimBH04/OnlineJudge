s, c, o, n = map(int, input().split())
print(min((s + n) // 3, (o * 2 + c) // 6))