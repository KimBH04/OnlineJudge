use std::{collections::VecDeque, io::{stdin, stdout, BufWriter, Read, Write}};

const BASE: [i128; 12] = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37];
static mut S1: i128 = 1;
static mut S2: i128 = 2;

fn power(mut n: i128, mut p: i128, m: i128) -> i128 {
    let mut re = 1;
    while p > 0 {
        if p % 2 == 1 {
            re = (re % m) * (n % m) % m;
        }
        n = (n % m) * (n % m) % m;
        p /= 2;
    }
    re
}

fn miller_rabin(a: i128, mut b: i128, n: i128) -> bool {
    while b % 2 == 0 {
        let x = power(a, b, n);
        if x == n - 1 {
            return true
        }
        if x != 1 {
            return false
        }
        b /= 2;
    }

    let y = power(a, b, n);
    if y == n - 1 || y == 1 {
        return true
    }
    false
}

fn is_prime(n: i128) -> bool {
    if BASE.contains(&n) {
        return true
    }
    if n == 0 || n == 1 || n % 2 == 0 {
        return false
    }

    for a in BASE {
        if !miller_rabin(a, n - 1, n) {
            return false
        }
    }
    true
}

fn gcd(mut a: i128, mut b: i128) -> i128 {
    if a < b {
        (a, b) = (b, a);
    }

    while b > 0 {
        (a, b) = (b, a % b);
    }
    a
}

fn rand(min: i128, max: i128) -> i128 {
    unsafe {
        let range = max - min;
    
        let mut x = S1;
        let y = S2;
        S1 = y;
        x ^= x << 23;
        S2 = x ^ y ^ (x >> 17) ^ (y >> 26);
        (S2 + y) % range + min
    }
}

fn rho(n: i128) -> Option<i128> {
    let mut x = rand(2, n);
    let mut y = x;

    let c = rand(1, n);
    let mut d = 1;
    while d == 1 {
        x = (x * x % n + c) % n;
        y = (y * y % n + c) % n;
        y = (y * y % n + c) % n;
        let z = x - y;
        d = gcd(n, if z > 0 { z } else { -z });
        if d == n {
            return None
        }
    }
    Some(d)
}

fn pollard_rho(n: i128) -> i128 {
    if is_prime(n) {
        return n
    }

    for a in BASE {
        if n % a == 0 {
            return a
        }
    }

    loop {
        if let Some(x) = rho(n) {
            return x
        }
    }
}

fn get_prime_factors(mut n: i128) -> Vec<i128> {
    let mut re = Vec::new();
    if n == 1 || is_prime(n) {
        re.push(n);
        return re
    }

    let mut factors = VecDeque::new();
    factors.push_front(n);
    while factors.len() > 0 {
        let f = factors.pop_back().unwrap();
        let pr = pollard_rho(f);
        if is_prime(pr) {
            n /= pr;
            if n != 1 {
                factors.push_front(n);
            }
            re.push(pr);
        }
        else {
            factors.push_front(pr);
        }
    }
    re.sort();
    re
}

fn main() {
    let mut buf = String::new();
    stdin().read_to_string(&mut buf).unwrap();
    let n = buf.split_whitespace().next().unwrap().parse::<i128>().unwrap();

    let mut write_buf = BufWriter::new(stdout().lock());

    for i in get_prime_factors(n).iter() {
        writeln!(write_buf, "{}", i).unwrap();
    }
}
