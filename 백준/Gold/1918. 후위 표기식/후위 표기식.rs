use std::io::{Write, stdin, stdout, BufWriter, Read};

fn main() {
    let mut buf = String::new();
    stdin().read_to_string(&mut buf).expect("input error");
    let s = buf.trim();

    let mut out = BufWriter::new(stdout().lock());
    let mut stack = Vec::new();
    for c in s.chars() {
        match c {
            '+' | '-' => {
                while let Some(o) = stack.pop() {
                    if o == '(' {
                        stack.push(o);
                        break;
                    }
                    write!(out, "{o}").unwrap();
                }
                stack.push(c);
            },
            '*' | '/' => {
                while let Some(o) = stack.pop() {
                    if o == '(' || o == '+' || o == '-' {
                        stack.push(o);
                        break;
                    }
                    write!(out, "{o}").unwrap();
                }
                stack.push(c);
            },
            '(' => stack.push('('),
            ')' => {
                while let Some(o) = stack.pop() {
                    if o == '(' {
                        break;
                    }
                    write!(out, "{o}").unwrap();
                }
            }
            _ => write!(out, "{c}").unwrap()
        }
    }

    while let Some(o) = stack.pop() {
        write!(out, "{o}").unwrap();
    }
}
