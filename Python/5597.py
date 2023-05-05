num = [1 for _ in range(30)]

t = 28
while t > 0:
    num[int(input()) - 1] -= 1
    t -= 1
    
for i in range(30):
    if num[i]:
        print(i + 1)