_input = input().split()
hour = int(_input[0])
minutes = int(_input[1])
addMinutes = int(input())

minutes = minutes + addMinutes

if minutes >= 60:
    hour = hour + int(minutes / 60)
    minutes = minutes % 60

if hour >= 24:
    hour = hour % 24

print(hour, minutes)