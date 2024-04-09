use std::io::stdin;

fn main() {
    let mut buf = String::new();
    stdin().read_line(&mut buf).unwrap();
    let n = buf.trim().parse::<usize>().unwrap();
    println!("{}", if n % 2 == 0 { "SciComLove" } else { "evoLmoCicS" });
}
