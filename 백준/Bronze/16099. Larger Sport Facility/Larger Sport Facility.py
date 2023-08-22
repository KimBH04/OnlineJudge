T = int(input())
while T:
    T -= 1
    lt, wt, le, we = map(int, input().split())
    t = lt * wt
    e = le * we
    if t > e:
        print('TelecomParisTech')
    elif t < e:
        print('Eurecom')
    else:
        print('Tie')