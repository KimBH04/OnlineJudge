x = int(input())
mo = 1
ja = 1

while x > 1:
    if mo >= ja:
        mo += 1
        x -= 1
        while mo > 1 and x > 1:
            mo -= 1
            ja += 1
            x -= 1
    else : # mo < ja
        ja += 1
        x -= 1
        while ja > 1 and x > 1:
            mo += 1
            ja -= 1
            x -= 1

result = str(ja) + '/' + str(mo)
print(result)