# 시간초과 낼 각오로 쓴건데 통과가 된다

input()
ls = list(map(int, input().split())) + list(map(int, input().split()))
ls.sort()

for i in ls:
    print(i, end=' ')