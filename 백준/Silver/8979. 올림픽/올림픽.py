n, k = map(int, input().split())
ls = [[*map(int, input().split())] for _ in range(n)] + [[0, 0, 0, 0]]
ls = sorted(ls, key=lambda x: x[3], reverse=1)
ls = sorted(ls, key=lambda x: x[2], reverse=1)
ls = sorted(ls, key=lambda x: x[1], reverse=1)
rank = 1
equal = 0
for i in range(n):
    if ls[i][0] == k and not print(rank):
        break
    if ls[i][1:] == ls[i + 1][1:]:
        equal += 1
    else:
        rank += equal + 1
        equal = 0