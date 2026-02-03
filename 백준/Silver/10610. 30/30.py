n = sorted([*input()], reverse=1)
print(-1 if n[-1] != '0' or sum(map(int, n)) % 3 else ''.join(n))