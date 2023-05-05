n = int(input())
voted = input().split()
results = {'-1':0, '0':0, '1':0}

for i in voted:
    results[i] += 1

if results['0'] > (n - 1) / 2:
    print('INVALID')
elif results['1'] > results['-1']:
    print('APPROVED')
else:
    print('REJECTED')