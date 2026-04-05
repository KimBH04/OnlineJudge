n, a, b, c, d = map(int, input().split())
x = n // a + (1 if n % a else 0)
y = n // c + (1 if n % c else 0)
print(min(x * b, y * d))