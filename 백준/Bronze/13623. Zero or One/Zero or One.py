a, b, c = map(int, input().split())

if b == c and a != b:
    print('A')
elif a == c and b != c:
    print('B')
elif a == b and a != c:
    print('C')
else:
    print('*')