k, l = map(int, input().split())
m = { input(): i for i in range(l) }
print('\n'.join(sorted(m, key=lambda x: m[x])[:k]))