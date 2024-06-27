def main(n: int):
    global results
    results = []
    back_tracking(['1'], 2, n)
    for result in results:
        print(result)

def back_tracking(ls: list, m: int, depth: int):
    if m > depth:
        global results
        s = ''.join(ls)
        sq = s.replace(' ', '')
        if eval(sq) == 0:
            results.append(s)
    else:
        for c in ' +-':
            ls.append(c + str(m))
            back_tracking(ls, m + 1, depth)
            ls.pop()

if __name__ == '__main__':
    t = int(input())
    while t:
        t -= 1
        main(int(input()))
        print()