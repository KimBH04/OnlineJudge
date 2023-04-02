t = int(input())

while t:
    _input = input().split()
    r = int(_input[0])
    temp = r
    s = list(_input[1])

    for c in s:
        while r:
            print(c, end='')
            r -= 1
        r = temp
    print()
    t -= 1