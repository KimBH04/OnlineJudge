use std::io::{stdin, Read};

fn main() {
    let buf = &mut String::new();
    stdin().read_to_string(buf).unwrap();
    let mut input = buf.split_whitespace();

    let n = input.next().unwrap().parse::<usize>().unwrap();
    let mut names = vec![""; n];
    for i in 0..n {
        names[i] = input.next().unwrap();
    }

    let mut sorted_names = names.clone();

    sorted_names.sort();
    if check(&names, &sorted_names, n) {
        println!("INCREASING");
        return;
    }

    sorted_names.reverse();
    if check(&names, &sorted_names, n) {
        println!("DECREASING");
        return;
    }

    println!("NEITHER");
}

fn check(a: &Vec<&str>, b: &Vec<&str>, n: usize) -> bool {
    for i in 0..n {
        if a[i] != b[i] {
            return false;
        }
    }
    true
}