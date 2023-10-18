from collections import deque

n = int(input())
a = input().split()
c = input().split()
dq = deque()
for i in range(n):
    if a[i] == '0':
        dq.append(c[i])

input()
for i in input().split():
    dq.appendleft(i)
    print(dq.pop(), end=' ')