use std::io::{stdin, Read};

fn main() {
    let mut buf = String::new();
    stdin().read_to_string(&mut buf).unwrap();
    let mut input = buf.split_whitespace().flat_map(str::parse::<usize>);
    
    let n = input.next().unwrap();
    let m = input.next().unwrap();
    
    let mut a = 1;
    for i in 2..=n {
        a = a % m * i % m;
        if a == 0 {
            break;
        }
    }
    println!("{a}");
}
