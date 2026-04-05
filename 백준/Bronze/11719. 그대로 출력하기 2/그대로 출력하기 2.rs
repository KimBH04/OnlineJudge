use std::io::{stdin, Read};

fn main() {
    let buf = &mut String::new();
    stdin().read_to_string(buf).unwrap();
    let mut input = buf.split('\n');

    while let Some(s) = input.next() {
        println!("{s}");
    }
}