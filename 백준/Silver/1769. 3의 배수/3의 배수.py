x = input()
cnt = 0
while len(x) > 1:
    x = str(sum(int(i) for i in x))
    cnt += 1
print(cnt)
print("NO" if int(x) % 3 else "YES")