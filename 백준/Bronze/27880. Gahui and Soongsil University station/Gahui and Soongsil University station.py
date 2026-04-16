r = 0
for i in range(4):
    a = input().split()
    r += int(a[1]) * (21 if a[0] == 'Es' else 17)

print(r)