use std::io::{stdin, Read};

fn main() {
    let mut floyd_warshall = [[false; 128]; 128];

    let buf = &mut String::new();
    stdin().read_line(buf).unwrap();
    let n = buf.trim().parse::<usize>().unwrap();

    buf.clear();
    stdin().read_to_string(buf).unwrap();
    let mut input = buf.split_whitespace().flat_map(str::parse::<char>);

    for _ in 0..n {
        let a = input.next().unwrap() as usize;
        let b = input.next().unwrap() as usize;
        floyd_warshall[a][b] = true;
    }

    for m in 0..128 {
        for i in 0..128 {
            for j in 0..128 {
                floyd_warshall[i][j] =
                if i == j {
                    false
                } else if floyd_warshall[i][m] && floyd_warshall[m][j] {
                    true
                } else {
                    floyd_warshall[i][j]
                }
            }
        }
    }

    let mut cnt = 0;
    let mut out = String::new();
    for i in 0..128 {
        for j in 0..128 {
            if floyd_warshall[i][j] {
                cnt += 1;
                out.push_str(&format!("\n{} => {}", i as u8 as char, j as u8 as char))
            }
        }
    }

    println!("{cnt}{out}");
}