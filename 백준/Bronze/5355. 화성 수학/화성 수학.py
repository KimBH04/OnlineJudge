times = int(input())
for i in range(times):
    yonsan = list(map(str, input().split()))
    num = float(yonsan[0])
    marsYonsan = yonsan[1:]
    for item in marsYonsan:
        if item == '@':
            num *= 3
        elif item == '%':
            num += 5
        elif item == '#':
            num -= 7
    print(f'{num:.2f}')