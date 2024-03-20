use std::io::{stdin, Read};

fn main() {
    let mut buffer = String::new();
    stdin().read_to_string(&mut buffer).unwrap();
    let mut input = buffer.split_ascii_whitespace().flat_map(str::parse::<i64>);

    let n = input.next().unwrap();
    let mut left = 1;
    let mut right = 1;
    let mut cnt = 0;

    while right <= n {
        let sum = (left + right) * (right - left + 1) / 2;
        if sum > n {
            left += 1;
        }
        else if sum < n {
            right += 1;
        }
        else {
            cnt += 1;
            right += 1;
        }
    }
    println!("{}", cnt);
}
