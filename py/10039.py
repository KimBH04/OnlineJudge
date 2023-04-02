ls = []

for i in range(5):
    ls.append(max(40, int(input())))

print(int(sum(ls) / 5))