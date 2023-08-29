n = int(input())
a, aa, b, bb = map(int, input().split())

m = 0
am = 0
bm = 0

i = n // aa
while i >= 0:
    j = (n - i * aa) // bb
    k = i * a + j * b
    if m < k:
        m = k
        am = i
        bm = j
    i -= 1

print(am, bm)