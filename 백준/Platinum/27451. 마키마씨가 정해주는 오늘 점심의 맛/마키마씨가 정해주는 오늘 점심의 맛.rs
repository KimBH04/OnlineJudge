use std::{collections::VecDeque, io::{stdin, Read}};

fn main() {
    let mut buffer = String::new();
    stdin().read_to_string(&mut buffer).expect("input panic");
    let mut input = buffer.split_whitespace().flat_map(str::parse::<usize>);

    let n = input.next().unwrap();
    let m = input.next().unwrap();

    let mut edge: Vec<Vec<usize>> = Vec::new();
    let mut visited: Vec<Vec<Vec<bool>>> = Vec::new();
    for i in 0..(n + 1) {
        edge.push(Vec::new());
        visited.push(Vec::new());
        for j in 0..(n + 1) {
            visited[i].push(Vec::new());
            for _ in 0..(n + 1) {
                visited[i][j].push(false);
            }
        }
    }

    let a = input.next().unwrap();
    let b = input.next().unwrap();
    let c = input.next().unwrap();
    visited[a][b][c] = true;
    
    for _ in 0..m {
        let s = input.next().unwrap();
        let e = input.next().unwrap();
        edge[s].push(e);
    }

    let mut deque = VecDeque::from([(a, b, c, a.to_string(), b.to_string(), c.to_string())]);

    let mut cnt = 0;
    let mut re = String::from("-1");
    'search: while deque.len() > 0 {
        let len = deque.len();
        for _ in 0..len {
            let v = deque.pop_front().unwrap();
            if v.0 == v.1 && v.0 == v.2 {
                drop(re);
                re = format!("{} {}\n{}\n{}\n{}", v.0, cnt, v.3, v.4, v.5);
                break 'search;
            }

            for i in edge[v.0].iter() {
                for j in edge[v.1].iter() {
                    for k in edge[v.2].iter() {
                        if !visited[*i][*j][*k] {
                            visited[*i][*j][*k] = true;
                            let mut pow_path = v.3.clone();
                            let mut den_path = v.4.clone();
                            let mut aki_path = v.5.clone();
    
                            let pow_next = format!(" {}", *i);
                            let den_next = format!(" {}", *j);
                            let aki_next = format!(" {}", *k);
    
                            pow_path.push_str(&pow_next);
                            den_path.push_str(&den_next);
                            aki_path.push_str(&aki_next);
                            
                            deque.push_back((*i, *j, *k, pow_path, den_path, aki_path));
                        }
                    }
                }
            }
        }
        cnt += 1;
    }
    println!("{}", re);
}
