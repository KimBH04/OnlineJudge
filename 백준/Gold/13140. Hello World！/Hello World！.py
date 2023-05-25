def main():
    n = int(input())

    for h in range(1, 10):

        for e in range(10):
            if h == e:
                continue

            for l in range(10):
                if h == l or e == l:
                    continue

                for o in range(10):
                    if h == o or e == o or l == o:
                        continue
                    
                    for w in range(1, 10):
                        if h == w or e == w or l == w or o == w:
                            continue

                        for r in range(10):
                            if h == r or e == r or l == r or o == r or w == r:
                                continue

                            for d in range(10):
                                if h == d or e == d or l == d or o == d or w == d or r == d:
                                    continue

                                hello = int(str(h) + str(e) + str(l) + str(l) + str(o))
                                world = int(str(w) + str(o) + str(r) + str(l) + str(d))

                                if hello + world == n:
                                    print('  ' + str(hello))
                                    print('+ ' + str(world))
                                    print('-------')

                                    if len(str(n)) > 5:
                                        return ' ' + str(n)
                                    else:
                                        return '  ' + str(n)

    return 'No Answer'

print(main())