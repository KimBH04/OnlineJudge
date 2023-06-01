n = int(input())
m = int(input())
s = input()

r = 0
i = "IO" * (len(s) // 2) + "I"
while len(i) >= n * 2 + 1:
    cnt = s.count(i)
    if cnt:
        r += (len(i) // 2 - n + 1) * cnt
        s = s.replace(i, "")
    i = i[2:]

print(r)
