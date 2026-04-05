use std::io::{stdin, Read};

fn back_tracking(arr: Vec<i32>, mut sum: i32, s: i32, start: usize, n: usize, m: usize, depth: usize) -> i32 {
    if m == depth {
        if sum == s { 1 } else { 0 }
    } else {
        let mut r = 0;
        for i in start..n {
            sum += arr[i];
            r += back_tracking(arr.clone(), sum, s, i + 1, n, m + 1, depth);
            sum -= arr[i];
        }
        r
    }
}

fn main() {
    let mut buf = String::new();
    stdin().read_to_string(&mut buf).expect("input panic");
    let mut input = buf.split_whitespace().flat_map(str::parse::<i32>);

    let n = input.next().unwrap() as usize;
    let s = input.next().unwrap();
    let mut arr = vec![0; n];
    for i in 0..n {
        arr[i] = input.next().unwrap();
    }

    let mut re = 0;
    for i in 1..=n {
        re += back_tracking(arr.clone(), 0, s, 0, n, 0, i);
    }
    println!("{re}");
}