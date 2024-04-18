use std::io::{stdin, Read};

fn main() {
    let buf = &mut String::new();
    stdin().read_to_string(buf).unwrap();
    let mut input = buf.split_whitespace().flat_map(str::parse::<usize>);

    let n = input.next().unwrap();
    let mut arr = vec![0; n];
    for i in 0..n {
        arr[i] = input.next().unwrap();
    }
    arr.sort();
    arr.reverse();

    let mut re = 0;
    for i in 0..n {
        if i % 3 == 2 {
            continue;
        }
        re += arr[i]
    }

    println!("{re}");
}
