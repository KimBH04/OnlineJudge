T = int(input())
if T % 10 == 0:
    fm = int(T / 300)
    T %= 300
    om = int(T / 60)
    T %= 60
    ts = int(T / 10)
    print(fm, om, ts)
else:
    print('-1')