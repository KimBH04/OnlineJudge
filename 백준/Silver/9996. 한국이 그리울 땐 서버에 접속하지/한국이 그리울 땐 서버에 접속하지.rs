use std::io::{stdin, Read};

fn main() {
    let buf = &mut String::new();
    stdin().read_to_string(buf).unwrap();
    let mut input = buf.split_whitespace();

    let n = input.next().unwrap().parse().unwrap();
    let mut regex = input.next().unwrap().split('*');
    let l: Vec<char> = regex.next().unwrap().chars().collect();
    let r: Vec<char> = regex.next().unwrap().chars().collect();
    let l_len = l.len();
    let r_len = r.len();

    'line: for _ in 0..n {
        let s: Vec<char> = input.next().unwrap().chars().collect();
        let s_len = s.len();
        if s_len < l_len + r_len {
            println!("NE");
            continue;
        }

        for i in 0..l_len {
            if s[i] != l[i] {
                println!("NE");
                continue 'line;
            }
        }

        for i in 0..r_len {
            if s[s_len - r_len + i] != r[i] {
                println!("NE");
                continue 'line;
            }
        }

        println!("DA");
    }
}
