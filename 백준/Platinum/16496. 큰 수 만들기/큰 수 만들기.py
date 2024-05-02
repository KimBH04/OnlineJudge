from functools import cmp_to_key

n = int(input())
arr = input().split()
arr.sort(key=cmp_to_key(lambda x, y: 1 if int(x + y) < int(y + x) else -1))
print(int(''.join(arr)))