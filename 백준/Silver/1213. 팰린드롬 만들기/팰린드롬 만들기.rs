use std::io::stdin;

fn main() {
    let mut buf = String::new();
    stdin().read_line(&mut buf).expect("input error");
    let name = String::from(buf.trim_end());

    let mut alphabets = [0; 26];
    for c in name.chars() {
        let i = c as usize - 65;
        alphabets[i] += 1;
    }

    let mut odd_cnt = 0;
    let mut odd = 26;
    for i in 0..26 {
        if alphabets[i] % 2 == 1 {
            odd_cnt += 1;
            odd = i;
        }
    }
    
    if odd_cnt > 1 {
        println!("I'm Sorry Hansoo");
    } else {
        let mut out = String::new();

        for i in 0..26 {
            for _ in 0..(alphabets[i] / 2) {
                out.push((i + 65) as u8 as char);
            }
        }

        if odd < 26 {
            out.push((odd + 65) as u8 as char);
        }

        for i in (0..26).rev() {
            for _ in 0..(alphabets[i] / 2) {
                out.push((i + 65) as u8 as char);
            }
        }

        println!("{out}");
    }
}
