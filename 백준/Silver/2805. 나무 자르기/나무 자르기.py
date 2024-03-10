n, m = map(int, input().split())
trees = list(map(int, input().split()))
left = 0
right = max(trees)
while left < right:
    mid2 = left + right
    mid = mid2 - mid2 // 2
    cnt = 0
    for i in trees:
        if i > mid:
            cnt += i - mid
    if cnt < m:
        right = mid - 1
    elif cnt > m:
        left = mid
    else:
        left = mid
        break
print(left)