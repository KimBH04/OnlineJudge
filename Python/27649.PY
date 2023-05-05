s = list(input())
fixed = []

word = ''
i = 0
while i < len(s):
    case1 = s[i] == '<' or s[i] == '>' or s[i] == '(' or s[i] == ')'
    case2 = s[i] == '&' or s[i] == '|'
    case3 = s[i] == ' '

    if case1 or case2 or case3:
        if word:
            fixed.append(word)
            word = ''

        if case1:
            fixed.append(s[i])
        elif case2:
            fixed.append(s[i] + s[i + 1])
            i += 1
    else:
        word += s[i]
    
    i += 1
fixed.append(word)

for f in fixed:
    print(f, end=' ')