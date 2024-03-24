use std::io::{stdin, Read};

fn main() {
    let mut buffer = String::new();
    stdin().read_to_string(&mut buffer).expect("input panic");
    let mut input = buffer.split_whitespace().flat_map(str::parse::<usize>);

    let mut t: Vec<usize> = Vec::new();
    let mut p: Vec<usize> = Vec::new();

    let n = input.next().unwrap();
    for _ in 0..n {
        t.push(input.next().unwrap());
        p.push(input.next().unwrap());
    }

    let mut max: usize = 0;
    let mut d: Vec<usize> = vec![0; n + 1];
    for idx in (0..n).rev() {
        if idx + t[idx] - 1 < n {
            d[idx] = p[idx] + d[idx + t[idx]];
        }
        if d[idx + 1] > d[idx] {
            d[idx] = d[idx + 1];
        }
        if d[idx] > max {
            max = d[idx];
        }
    }
    print!("{}", max);
}
