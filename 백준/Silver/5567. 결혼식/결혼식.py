n = int(input()) + 1
m = int(input())
ls = [[] for _ in range(n)]
for i in range(m):
    a, b = map(int, input().split())
    ls[a].append(b)
    ls[b].append(a)

v = [0] * n
v[1] = 1

q = [1]
while q:
    i = q[0]
    del q[0]
    for j in ls[i]:
        if v[j] or v[i] > 2:
            continue
        v[j] = v[i] + 1
        q.append(j)
        
cnt = -1
for i in v:
    cnt += i > 0
    
print(cnt)