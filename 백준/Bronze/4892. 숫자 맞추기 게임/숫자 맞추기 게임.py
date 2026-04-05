t = 0
while 1:
    t += 1
    n = int(input())
    if n == 0:
        break
    print(str(t) + '.', end=' ')

    n *= 3
    print('odd' if n % 2 else 'even', end=' ')

    if n % 2:
        n += 1
    n //= 2

    n *= 3

    n //= 9
    print(n)