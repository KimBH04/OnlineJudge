n, m = map(int, input().split())
sx, sy = map(int, input().split())
ex, ey = map(int, input().split())

if n == 1 or m == 1:
    if sx == ex and sy == ey:
        print("YES")
    else:
        print("NO")
elif sx % 2 ^ sy % 2 == ex % 2 ^ ey % 2:
    print("YES")
else:
    print("NO")