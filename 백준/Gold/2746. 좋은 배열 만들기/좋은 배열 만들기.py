n = int(input())
a = []
dic = {}
total = 0
for s in input().split():
    i = int(s)
    if i in dic:
        dic[i] += 1
    else:
        dic[i] = 1
    a.append(i)
    total += i
a.sort()

cnt = (total == a[-1] + a[-2] + a[-3] + a[-3]) + sum(total == a[-1] + a[-2] + a[-2] + a[i] for i in range(n - 2))
for i in range(n - 2):
    dic[a[i]] -= 1
    left = i + 1
    right = n - 2
    flag = 0
    while left <= right:
        mid = (left + right) >> 1
        value = a[i] + a[mid] + a[-1] + a[-1]
        if value > total:
            right = mid
        elif value < total:
            left = mid + 1
        else:
            cnt += dic[a[mid]]
            break
        if left == right:
            if flag:
                break
            else:
                flag = 1
print(cnt)