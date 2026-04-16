M = 1000000007
a = int(input()) % M
x = int(input())
r = 1
while x > 0:
    if x & 1:
        r *= a
        r %= M
        x -= 1
    a *= a
    a %= M
    x >>= 1
print(r)