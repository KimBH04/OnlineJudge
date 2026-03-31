n = int(input())
dic = {}
while n > 0:
    n -= 1
    extension = input().split('.')[1]
    if extension in dic:
        dic[extension] += 1
    else:
        dic[extension] = 1

for ex, cnt in sorted(dic.items(), key=lambda x: x[0]):
    print(ex, cnt)