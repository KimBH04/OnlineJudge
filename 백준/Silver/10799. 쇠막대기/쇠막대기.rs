use std::io::stdin;

fn main() {
    let buf = &mut String::new();
    stdin().read_line(buf).unwrap();

    let mut cnt = 0;
    let mut stack = 0;
    for c in buf.trim().replace("()", "|").chars() {
        match c {
            '(' => stack += 1,
            '|' => cnt += stack,
            ')' => { stack -= 1; cnt += 1; },
            _ => panic!()
        }
    }
    print!("{cnt}");
}
