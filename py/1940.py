n = int(input())
m = int(input())
ls = list(map(int, input().split()))
ls.sort()

r = 0
left = 0
right = n - 1

while left <= right:
    if left == right and ls[left] == m:
        r += 1
        break
    elif ls[left] + ls[right] < m:
        left += 1
    elif ls[left] + ls[right] > m:
        right -= 1
    else:
        r += 1
        left += 1

print(r)