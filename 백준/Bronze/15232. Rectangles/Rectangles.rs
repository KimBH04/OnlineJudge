use std::io::{stdin, Read};

fn main() {
    let buf = &mut String::new();
    stdin().read_to_string(buf).unwrap();
    let mut input = buf.split_whitespace().flat_map(str::parse);
    let r = input.next().unwrap();
    let c = input.next().unwrap();
    for _ in 0..r {
        for _ in 0..c {
            print!("*");
        }
        println!();
    }
}
