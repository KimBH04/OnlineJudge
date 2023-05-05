n = int(input())

while n:
    a, b = map(int, input().split())
    A = a
    B = b

    while a != b:
        if a < b:
            a += A
        elif a > b:
            b += B

    print(a)
    n -= 1