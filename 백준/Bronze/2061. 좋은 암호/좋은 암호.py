def main():
    k, l = map(int, input().split())
    for i in range(2, l):
        if k % i == 0:
            return f'BAD {i}'
    return 'GOOD'

if __name__ == '__main__':
    print(main())