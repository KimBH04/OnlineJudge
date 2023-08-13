def area(l):
    if l < 250:
        return 4
    if l < 275:
        return 3
    if l < 300:
        return 2
    return 1
    
input()
for i in input().split():
    print(area(int(i)), end=' ')