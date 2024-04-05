use std::io::{stdin, Read};

fn main() {
    let mut buf = String::new();
    stdin().read_to_string(&mut buf).unwrap();
    let mut input = buf.split_whitespace().flat_map(str::parse::<usize>);

    let n = input.next().unwrap();
    let k = input.next().unwrap();
    let mut max = 1;
    let mut arr = [0; 100001];
    let mut a = vec![0; n];
    let mut left = 0;
    for right in 0..n {
        a[right] = input.next().unwrap();
        arr[a[right]] += 1;
        while arr[a[right]] > k {
            arr[a[left]] -= 1;
            left += 1;
        }
        if max < right - left + 1 {
            max = right - left + 1;
        }
    }
    println!("{max}");
}
