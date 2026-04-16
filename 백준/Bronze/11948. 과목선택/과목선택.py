ls = [0, 0, 0, 0, 0, 0]
for i in range(6):
    ls[i] = int(input())

r = sum(sorted(ls[:4])[1:4]) + sorted(ls[4:])[-1]

print(r)