import sys

def Slicing(n:int, line:list) -> list:
    if n == 1:
        return ['-']
    
    l = n // 3
    for i in range(l, l * 2):
        line[i] = ' '

    r = Slicing(l, line[:l]) + line[l:l * 2] + Slicing(l, line[l * 2:])
    return r

def main():
    lines = sys.stdin.readlines()

    for line in lines:
        n = int(line)
        _len = 3 ** n
        r = Slicing(_len, ['-' for i in range(_len)])

        for c in r:
            print(c, end='')

        print()

if __name__ == '__main__':
    main()