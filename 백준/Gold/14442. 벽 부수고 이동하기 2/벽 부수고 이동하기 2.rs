use std::{collections::VecDeque, io::{stdin, Read}};

fn main() {
    let buf = &mut String::new();
    stdin().read_to_string(buf).unwrap();
    let mut input = buf.split_whitespace();

    let n = input.next().unwrap().parse::<usize>().unwrap();
    let m = input.next().unwrap().parse::<usize>().unwrap();
    let k = input.next().unwrap().parse::<usize>().unwrap();
    let mut map = vec![vec![false; m]; n];
    let mut visited = vec![vec![vec![false; m]; n]; k + 1];
    for i in 0..n {
        let mut line = input.next().unwrap().chars();
        for j in 0..m {
            map[i][j] = line.next().unwrap() == '1';
        }
    }

    let mut queue = VecDeque::new();
    visited[k][0][0] = true;
    queue.push_back((k, 0, 0));

    let mut cnt = 1;
    while queue.len() > 0 {
        let qcnt = queue.len();
        for _ in 0..qcnt {
            let (k, r, c) = queue.pop_front().unwrap();
            if r == n - 1 && c == m - 1 {
                println!("{cnt}");
                return;
            }

            if r > 0 && !visited[k][r - 1][c] {
                if !map[r - 1][c] {
                    visited[k][r - 1][c] = true;
                    queue.push_back((k, r - 1, c));
                } else if k > 0 && !visited[k - 1][r - 1][c] {
                    visited[k - 1][r - 1][c] = true;
                    queue.push_back((k - 1, r - 1, c));
                }
            }
            if r + 1 < n && !visited[k][r + 1][c] {
                if !map[r + 1][c] {
                    visited[k][r + 1][c] = true;
                    queue.push_back((k, r + 1, c));
                } else if k > 0 && !visited[k - 1][r + 1][c]  {
                    visited[k - 1][r + 1][c] = true;
                    queue.push_back((k - 1, r + 1, c));
                }
            }
            if c > 0 && !visited[k][r][c - 1] {
                if !map[r][c - 1] {
                    visited[k][r][c - 1] = true;
                    queue.push_back((k, r, c - 1));
                } else if k > 0 && !visited[k - 1][r][c - 1]  {
                    visited[k - 1][r][c - 1] = true;
                    queue.push_back((k - 1, r, c - 1));
                }
            }
            if c + 1 < m && !visited[k][r][c + 1] {
                if !map[r][c + 1] {
                    visited[k][r][c + 1] = true;
                    queue.push_back((k, r, c + 1));
                } else if k > 0 && !visited[k - 1][r][c + 1]  {
                    visited[k - 1][r][c + 1] = true;
                    queue.push_back((k - 1, r, c + 1));
                }
            }
        }
        cnt += 1;
    }
    println!("-1");
}
