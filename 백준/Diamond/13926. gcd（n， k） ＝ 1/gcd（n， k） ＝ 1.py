from random import randrange

BASE = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37]

def gcd(a: int, b: int) -> int:
    a = -a if a < 0 else a
    b = -b if b < 0 else b
    
    while b > 0:
        a, b = b, a % b
    return a

def power_mod(n: int, p: int, m: int) -> int:
    r = 1
    n %= m
    while p > 0:
        if p & 1:
            r *= n
            r %= m
        n *= n
        n %= m
        p >>= 1
    return r

def miller_rabin(a: int, b: int, n: int) -> bool:
    while b & 1 == 0:
        x = power_mod(a, b, n)
        if x == n - 1:
            return True
        if x != 1:
            return False
        b >>= 1
    
    y = power_mod(a, b, n)
    if y == n - 1 or y == 1:
        return True
    return False

def is_prime(n: int) -> bool:
    if n in BASE:
        return True
    
    if n < 2 or any(n % p == 0 for p in BASE):
        return False
    
    for p in BASE:
        if not miller_rabin(p, n - 1, n):
            return False
    return True

def pollard_rho(n: int) -> int:
    if n == 1 or is_prime(n):
        return n
    
    for p in BASE:
        if n % p == 0:
            return p
    
    while 1:
        x = randrange(2, n)
        y = x

        c = randrange(1, n)
        d = 1
        while d == 1:
            x = (x * x % n + c) % n
            y = (y * y % n + c) % n
            y = (y * y % n + c) % n
            z = x - y
            d = gcd(n, -z if z < 0 else z)
            if d == n:
                x = randrange(2, n)
                y = x
                c = randrange(1, n)
                break
        if d != n:
            return d
        
def get_factors(n: int) -> set[int]:
    factors = set()
    if n == 1:
        return set()

    if is_prime(n):
        factors.add(n)
        return factors
    
    f = pollard_rho(n)
    factors.update(get_factors(f))
    factors.update(get_factors(n // f))
    return factors

n = int(input())

if n == 1:
    print(1)
    quit()

if is_prime(n):
    print(n - 1)
    quit()

factors = get_factors(n)
if len(factors) == 1:
    print(n - (n // factors.pop()))
    quit()

phi = n
for f in factors:
    phi -= phi // f
print(phi)