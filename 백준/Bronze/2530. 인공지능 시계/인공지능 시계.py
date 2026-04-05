timerstr = list(map(int, input().split()))
Hour = timerstr[0]
Minutes = timerstr[1]
Second = timerstr[2] + int(input())
if Second >= 60:
    Minutes += int(Second / 60)
    Second %= 60
if Minutes >= 60:
    Hour += int(Minutes / 60)
    Minutes %= 60
if Hour >= 24:
    Hour %= 24
print(Hour, Minutes, Second)