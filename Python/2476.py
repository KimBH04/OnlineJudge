n = int(input())
ls = []

while n:
    dice= list(map(int, input().split()))
    dice.sort()

    r = 0
    if dice[0] == dice[1] == dice[2]:
        r = 10000 + dice[0] * 1000
    elif  dice[0] == dice[1] or dice[1] == dice[2]:
        r = 1000 + max(dice) * 100
    else:
        r = max(dice) * 100

    ls.append(r)
    n -= 1

print(max(ls))