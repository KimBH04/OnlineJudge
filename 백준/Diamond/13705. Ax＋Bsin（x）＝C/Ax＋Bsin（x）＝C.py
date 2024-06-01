from decimal import *

MOD = 2 * Decimal('3.141592653589793238462643383279502884197169399375105820974944592307816406286208998')

def main():
    global A, B, C
    A, B, C = map(int, input().split())
    a, b = Decimal(0), Decimal(1000000)
    n, m = AxBsinxC(a), None
    tol = Decimal('0.' + '0' * 31 + '1')
    while b - a > tol:
        mid = (a + b) / 2
        m = AxBsinxC(mid)
        
        if n * m < 0:
            b = mid
        else:
            a = mid
            n = m
    print(b.quantize(Decimal('0.000000'), ROUND_HALF_UP))

def AxBsinxC(x: Decimal) -> Decimal:
    global A, B, C
    return (A * x) + (B * sin(x)) - C

def sin(x: Decimal) -> Decimal:
    x %= MOD
    i, lasts, s, fact, num, sign = 1, 0, x, 1, x, 1
    while s != lasts:
        lasts = s
        i += 2
        fact *= i * (i - 1)
        num *= x * x
        sign *= -1
        s += num / fact * sign
    return +s

if __name__ == '__main__':
    getcontext().prec = 64
    main()