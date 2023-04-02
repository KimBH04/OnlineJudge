s = list(input())

r = 0
grt = ' '
for i in range(len(s)):
    if grt == s[i]:
        r += 5
    else:
        r += 10
        grt = s[i]

print(r)