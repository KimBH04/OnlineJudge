use std::io::stdin;

fn main() {
    let buf = &mut String::new();
    stdin().read_line(buf).unwrap();

    let n = buf.trim().parse::<usize>().unwrap();

    let mut primes = vec![0; 1];
    let mut eratos = vec![true; n + 1];
    eratos[0] = false;
    eratos[1] = false;
    for i in 2..=n {
        if eratos[i] {
            primes.push(primes.last().unwrap() + i);
            let mut j = i + i;
            while j <= n {
                eratos[j] = false;
                j += i;
            }
        }
    }

    let len = primes.len();
    let mut left = 0;
    let mut right = 1;
    let mut cnt = 0;
    while right < len {
        let sum = primes[right] - primes[left];
        if sum < n {
            right += 1;
        } else if sum > n {
            left += 1;
        } else {
            cnt += 1;
            right += 1;
            left += 1;
        }
    }
    println!("{cnt}");
}
