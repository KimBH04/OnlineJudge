from math import log10

t = int(input())
while t:
    t -= 1
    n, k = map(int, input().split())
    re = []
    while n:
        if k < int('1' * n):
            run_str = '9' * (n - 1)
            k -= int(run_str)
            re.append(run_str)
        else:
            for c in '987654321':
                run_str = c * n
                run_number = int(run_str)
                if k >= run_number:
                    k -= run_number
                    re.append(run_str)
                    break
        n = int(log10(k)) + 1 if k else 0
    print(len(re), ' '.join(re), sep='\n')