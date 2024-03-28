use std::{collections::HashMap, io::{stdin, stdout, BufWriter, Read, Write}};

fn main() {
    let mut buf = String::new();
    stdin().read_to_string(&mut buf).expect("input panic");
    let mut input = buf.split_whitespace();

    let n = input.next().unwrap().parse::<usize>().unwrap();
    let m = input.next().unwrap().parse::<usize>().unwrap();

    let mut dic: HashMap<String, String> = HashMap::new();
    for _ in 0..n {
        dic.insert(input.next().unwrap().to_string(), input.next().unwrap().to_string());
    }

    let mut write_buf = BufWriter::new(stdout().lock());

    for _ in 0..m {
        let str = dic.get(input.next().unwrap()).unwrap();
        writeln!(write_buf, "{}", str).unwrap();
    }
}
