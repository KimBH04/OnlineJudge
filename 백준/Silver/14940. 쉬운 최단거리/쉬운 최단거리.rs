use std::{collections::VecDeque, io::{stdin, stdout, BufWriter, Read, Write}};

fn main() {
    let buf = &mut String::new();
    stdin().read_to_string(buf).unwrap();
    let mut input = buf.split_whitespace().flat_map(str::parse::<usize>);

    let n = input.next().unwrap();
    let m = input.next().unwrap();

    let mut queue = VecDeque::new();
    let mut map = Vec::new();
    let mut visited = Vec::new();
    for i in 0..n {
        map.push(vec![0; m]);
        visited.push(vec![false; m]);
        for j in 0..m {
            map[i][j] = input.next().unwrap();
            if map[i][j] == 2 {
                map[i][j] = 0;
                queue.push_front((i, j));
                visited[i][j] = true;
            }
        }
    }

    while let Some((r, c)) = queue.pop_back() {
        if r > 0 && map[r - 1][c] != 0 && !visited[r - 1][c] {
            visited[r - 1][c] = true;
            map[r - 1][c] += map[r][c];
            queue.push_front((r - 1, c));
        }
        if c > 0 && map[r][c - 1] != 0 && !visited[r][c - 1] {
            visited[r][c - 1] = true;
            map[r][c - 1] += map[r][c];
            queue.push_front((r, c - 1));
        }
        if r < n - 1 && map[r + 1][c] != 0 && !visited[r + 1][c] {
            visited[r + 1][c] = true;
            map[r + 1][c] += map[r][c];
            queue.push_front((r + 1, c));
        }
        if c < m - 1 && map[r][c + 1] != 0 && !visited[r][c + 1] {
            visited[r][c + 1] = true;
            map[r][c + 1] += map[r][c];
            queue.push_front((r, c + 1));
        }
    }

    let out = &mut BufWriter::new(stdout().lock());
    for i in 0..n {
        for j in 0..m {
            write!(out, "{} ",
                if visited[i][j] || map[i][j] != 1 {
                    map[i][j].to_string()
                } else {
                    (-1).to_string()
                }
            ).unwrap();
        }
        writeln!(out).unwrap();
    }
}
