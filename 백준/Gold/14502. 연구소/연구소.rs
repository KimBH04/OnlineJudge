use std::{collections::VecDeque, io::{stdin, Read}};

fn main() {
    let buf = &mut String::new();
    stdin().read_to_string(buf).unwrap();
    let mut input = buf.split_whitespace().flat_map(str::parse::<usize>);

    let n = input.next().unwrap();
    let m = input.next().unwrap();
    let mut map = vec![vec![0; m]; n];
    for i in 0..n {
        for j in 0..m {
            map[i][j] = input.next().unwrap();
        }
    }

    let mut max = 0;
    for a in 0..n {
        for b in 0..m {
            if map[a][b] != 0 {
                continue;
            }

            map[a][b] = 1;
            for c in 0..n {
                for d in 0..m {
                    if map[c][d] != 0 {
                        continue;
                    }
        
                    map[c][d] = 1;
                    for e in 0..n {
                        for f in 0..m {
                            if map[e][f] != 0 {
                                continue;
                            }
                
                            map[e][f] = 1;

                            let mut queue = VecDeque::new();
                            let mut visited = vec![vec![false; m]; n];
                            for i in 0..n {
                                for j in 0..m {
                                    if map[i][j] == 2 {
                                        visited[i][j] = true;
                                        queue.push_back((i, j));
                                    }
                                }
                            }

                            while let Some((r, c)) = queue.pop_front() {
                                if r > 0 && map[r - 1][c] == 0 && !visited[r - 1][c] {
                                    visited[r - 1][c] = true;
                                    queue.push_back((r - 1, c));
                                }
                                if c > 0 && map[r][c - 1] == 0 && !visited[r][c - 1] {
                                    visited[r][c - 1] = true;
                                    queue.push_back((r, c - 1));
                                }
                                if r + 1 < n && map[r + 1][c] == 0 && !visited[r + 1][c] {
                                    visited[r + 1][c] = true;
                                    queue.push_back((r + 1, c));
                                }
                                if c + 1 < m && map[r][c + 1] == 0 && !visited[r][c + 1] {
                                    visited[r][c + 1] = true;
                                    queue.push_back((r, c + 1));
                                }
                            }

                            let mut cnt = 0;
                            for i in 0..n {
                                for j in 0..m {
                                    if map[i][j] == 0 && !visited[i][j] {
                                        cnt += 1;
                                    }
                                }
                            }

                            if max < cnt {
                                max = cnt;
                            }

                            map[e][f] = 0;
                        }
                    }
                    map[c][d] = 0;
                }
            }
            map[a][b] = 0;
        }
    }
    println!("{max}");
}