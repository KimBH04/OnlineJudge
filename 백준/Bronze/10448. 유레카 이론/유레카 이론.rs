use std::io::{stdin, Read};

fn main() {
    let mut buf = String::new();
    stdin().read_to_string(&mut buf).unwrap();
    let mut input = buf.split_whitespace().flat_map(str::parse::<usize>);

    let t = input.next().unwrap();
    'main: for _ in 0..t {
        let n = input.next().unwrap();
        for i in 1..n {
            for j in 1..n {
                for k in 1..n {
                    if i * (i + 1) / 2 + j * (j + 1) / 2 + k * (k + 1) / 2 == n {
                        println!("1");
                        continue 'main;
                    }
                }
            }
        }
        println!("0");
    }
}
