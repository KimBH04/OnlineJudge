use std::{io::{stdin, stdout, BufWriter, Read, Write}, iter::FromIterator};

fn main() {
    let mut buf = String::new();
    stdin().read_to_string(&mut buf).unwrap();
    let mut input = buf.split_whitespace();
    
    let mut out = BufWriter::new(stdout().lock());
    let n = input.next().unwrap().parse::<usize>().unwrap();
    for i in 1..=n {
        writeln!(out, "Case # {i}:").unwrap();
        let arr = Vec::from_iter(input.next().unwrap().chars().into_iter());
        let len = arr.len();
        back_tracking(&mut out, &arr , &mut vec!['\0'; len], &mut vec![false; len], len, 0, len);
    }
}

fn back_tracking<T: Write>(out: &mut BufWriter<T>, chars: &Vec<char>, s: &mut Vec<char>, v: &mut Vec<bool>, n: usize, m: usize, depth: usize) {
    if m == depth {
        writeln!(out, "{}", String::from_iter(s.iter())).unwrap();
    } else {
        for i in 0..n {
            if !v[i] {
                s[m] = chars[i];
                v[i] = true;
                back_tracking(out, chars, s, v, n, m + 1, depth);
                v[i] = false;
            }
        }
    }
}