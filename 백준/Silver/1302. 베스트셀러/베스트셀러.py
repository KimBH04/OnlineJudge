n = int(input())
dic = {}
while n:
    n -= 1
    s = input()
    if s in dic:
        dic[s] += 1
    else:
        dic[s] = 1
print(sorted(sorted(dic.items(), key=lambda x: x[0]), key=lambda x: x[1], reverse=True)[0][0])