use std::{fmt::Write, io::{stdin, Read}};

fn main() {
    let mut read_buffer = String::new();
    stdin().read_to_string(&mut read_buffer).unwrap();
    let mut input = read_buffer.split_ascii_whitespace().flat_map(str::parse::<i32>);

    const M: i32 = 1000000;

    let mut sort_vec = vec![0; (M * 2 + 1) as usize];
    let n = input.next().unwrap();
    for _ in 0..n {
        let a = (input.next().unwrap() + M) as usize;
        sort_vec[a] += 1;
    }

    let mut write_buffer = String::new();

    for i in 0..(M * 2 + 1) as usize {
        let cnt = sort_vec[i];
        for _ in 0..cnt {
            let mut f = format!("{}\n", (i as i32) - M);
            write_buffer.write_str(&mut f).unwrap();
        }
    }

    print!("{}", write_buffer);
}
