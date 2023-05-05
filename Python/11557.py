t = int(input())

while t:
    ls = []
    n = int(input())
    while n:
        ls.append(input().split())
        n -= 1

    ls = sorted(ls, key=lambda s: int(s[1]), reverse=True)
    print(ls[0][0])
    t -= 1