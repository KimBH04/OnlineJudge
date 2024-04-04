use std::{io::stdin, iter::FromIterator};

fn main() {
    let mut buf = String::new();
    stdin().read_line(&mut buf).unwrap();
    let arr = Vec::from_iter(buf.trim().chars());
    let len = arr.len();
    let sqrt = (len as f64).sqrt() as usize;

    let mut min = 0;
    let mut max = sqrt - 1;
    while max > min {
        let mut r = sqrt / 2;
        let mut c = min;
        while r > min {
            print!("{}", arr[r * sqrt + c]);
            r -= 1;
            c += 1;
        }
        while c < max {
            print!("{}", arr[r * sqrt + c]);
            r += 1;
            c += 1;
        }
        while r < max {
            print!("{}", arr[r * sqrt + c]);
            r += 1;
            c -= 1;
        }
        while c > min {
            print!("{}", arr[r * sqrt + c]);
            r -= 1;
            c -= 1;
        }
        min += 1;
        max -= 1;
    }
    println!("{}", arr[len / 2]);
}