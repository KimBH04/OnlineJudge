ls = []
for i in range(29):
    for j in range(28):
        ls.append((i * 562 - 8140, j * 562 - 8140))
ls += [(8140 - 200, 8140), (8140 - 200 - 561, 8140)]
for x, y in ls:
    print(f"{x}, {y}")