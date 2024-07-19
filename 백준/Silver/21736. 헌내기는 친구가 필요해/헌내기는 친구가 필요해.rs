use std::{collections::VecDeque, io::stdin};

fn main() {
    let buf = &mut String::new();
    stdin().read_line(buf).unwrap();
    let mut size = buf.split_whitespace().flat_map(str::parse);
    let n = size.next().unwrap();
    let m = size.next().unwrap();

    let mut start = (0, 0);
    let mut map = vec![vec!['\0'; m + 1]; n + 1];
    for i in 1..=n {
        buf.clear();
        stdin().read_line(buf).unwrap();
        let line: Vec<char> = buf.chars().collect();
        for j in 1..=m {
            map[i][j] = if line[j - 1] == 'I' {
                start = (i, j);
                'X'
            } else {
                line[j - 1]
            }
        }
    }

    const DIR: [(usize, usize); 4] = [(0, 1), (1, 0), (1, 2), (2, 1)];
    let mut cnt = 0;
    let mut queue = VecDeque::from([start]);
    while let Some((r, c)) = queue.pop_front() {
        for i in 0..4 {
            let tr = r + DIR[i].0 - 1;
            let tc = c + DIR[i].1 - 1;
            if 1 <= tr && tr <= n && 1 <= tc && tc <= m && map[tr][tc] != 'X' {
                if map[tr][tc] == 'P' {
                    cnt += 1;
                }
                map[tr][tc] = 'X';
                queue.push_back((tr, tc));
            }
        }
    }
    println!("{}", if cnt > 0 { cnt.to_string() } else { String::from("TT") });
}
