from math import *


def calculater(a: int, b: int, o: str):
    if o == "+":
        return a + b
    if o == "-":
        return a - b
    if o == "*":
        return a * b
    if o == "/":
        return floor(a / b)


n = ["", ""]
at = 0
o = " "

s = input()
for i in range(len(s)):
    if ord(s[i]) < 48 and i > 0 and o == " ":
        o = s[i]
        at = 1
    else:
        n[at] += s[i]

a = int(n[0], base=8)
b = int(n[1], base=8)

try:
    r = calculater(a, b, o)
    print(oct(r).replace("0o", ""))
except:
    print("invalid")

# 파이썬 최고다
