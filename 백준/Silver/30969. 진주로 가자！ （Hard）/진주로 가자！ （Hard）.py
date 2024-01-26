from sys import stdin

n = int(stdin.readline())
jinju = 0
price = [0] * n
while n:
    n -= 1

    a = stdin.readline().split()
    d = a[0]
    c = int(a[1])

    if d == 'jinju':
        jinju = c
        
    price[n] = c

r = 0
for i in price:
    if i > jinju:
        r += 1

print(jinju)
print(r)