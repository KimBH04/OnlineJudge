# 시간초과 낼 각오로 올리는 코드
input()
ls = list(map(int, input().split())) + list(map(int, input().split()))
ls.sort()

for i in ls:
    print(i, end=' ')