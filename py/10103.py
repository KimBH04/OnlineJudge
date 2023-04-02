n = int(input())

c, s = 100, 100
while n:
    cd, sd = map(int, input().split())
    if cd != sd:
        if cd > sd:
            s -= cd
        else:
            c -= sd
    
    n -= 1

print(c, s, sep='\n')