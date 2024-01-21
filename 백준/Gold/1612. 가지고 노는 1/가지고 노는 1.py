n = int(input())

if n % 2 and n % 5:
    ones = 1
    digit = 1
    while ones % n or print(digit):
        ones *= 10
        ones %= n
        ones += 1
        digit += 1
else:
    print(-1)