from sys import stdout

def back_tracking(num, n, m, depth):
    if m >= depth:
        for i in num:
            stdout.write(f'{i} ')
        stdout.write('\n')
    else:
        for i in range(1, n + 1):
            num[m] = i
            back_tracking(num, n, m + 1, depth)
            
n, m = map(int, input().split())
back_tracking([0] * m, n, 0, m)