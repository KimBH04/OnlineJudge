use std::io::{stdin, BufRead, BufReader};

fn main() {
    let mut reader = BufReader::new(stdin().lock());
    let buf = &mut String::new();

    reader.read_line(buf).unwrap();
    let t = buf.trim().parse().unwrap();
    'head: for _ in 0..t {
        buf.clear();
        reader.read_line(buf).unwrap();

        let mut re = 0;
        let mut max = 0;
        let mut alpha = [0; 26];
        for s in buf.split_whitespace() {
            for c in s.chars() {
                let i = c as usize - 97;
                alpha[i] += 1;
                if max < alpha[i] {
                    max = alpha[i];
                    re = i + 97;
                }
            }
        }

        for i in 0..26 {
            if i + 97 != re && alpha[i] == max {
                println!("?");
                continue 'head;
            }
        }

        println!("{}", re as u8 as char);
    }
}
