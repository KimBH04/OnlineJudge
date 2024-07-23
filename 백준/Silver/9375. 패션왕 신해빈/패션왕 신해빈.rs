use std::{collections::HashMap, io::{stdin, Read}};

fn main() {
    let buf = &mut String::new();
    stdin().read_to_string(buf).unwrap();
    let mut input = buf.split_whitespace();
    
    let n = input.next().unwrap().parse().unwrap();
    for _ in 0..n {
        let m = input.next().unwrap().parse().unwrap();
        let mut dict = HashMap::new();
        for _ in 0..m {
            input.next();
            let kind = input.next().unwrap();
            *dict.entry(kind).or_insert(0) += 1;
        }
        let mut multi = 1;
        for &v in dict.values() {
            multi *= v + 1;
        }
        println!("{}", multi - 1);
    }
}
