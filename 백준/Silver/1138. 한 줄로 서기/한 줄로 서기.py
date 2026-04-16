n = int(input())
ls = [*map(int, input().split())]
result = [0] * n
for i in range(n):
    cnt = ls[i]
    zero_cnt = result[:cnt].count(0)
    while result[cnt] or zero_cnt < ls[i]:
        if result[cnt] == 0:
            zero_cnt += 1
        cnt += 1
    result[cnt] = i + 1
print(' '.join(str(i) for i in result))