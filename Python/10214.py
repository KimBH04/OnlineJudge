t = int(input())

yonsei = 0
korea = 0
while t:
    n = 9
    while n:
        y, k = map(int, input().split())
        yonsei += y
        korea += k
        n -= 1

    if yonsei > korea:
        print('Yonsei')
    elif korea > yonsei:
        print('Korea')
    else:
        print('Draw')
    
    t -= 1