_input = input().split()
a, b = int(_input[0], 2), int(_input[1], 2)
print(bin(a + b)[2:])