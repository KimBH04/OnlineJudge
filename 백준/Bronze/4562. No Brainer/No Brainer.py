n = int(input())

while n:
    x, y = map(int, input().split())
    if x < y:
        print('NO BRAINS')
    else:
        print('MMM BRAINS')
    
    n -= 1