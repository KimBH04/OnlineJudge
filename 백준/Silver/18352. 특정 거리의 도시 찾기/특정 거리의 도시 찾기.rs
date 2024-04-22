use std::{collections::VecDeque, io::{stdin, Read}};

fn main() {
    let buf = &mut String::new();
    stdin().read_to_string(buf).unwrap();
    let mut input = buf.split_whitespace().flat_map(str::parse::<usize>);

    let n = input.next().unwrap();
    let m = input.next().unwrap();
    let k = input.next().unwrap();
    let x = input.next().unwrap();

    let mut edges = vec![Vec::new(); n + 1];
    for _ in 0..m {
        let a = input.next().unwrap();
        let b = input.next().unwrap();
        edges[a].push(b);
    }

    match search(edges, k, x, n) {
        Some(r) => for v in r {
            println!("{v}");
        },
        None => println!("-1")
    }
}

fn search(edges: Vec<Vec<usize>>, k: usize, x: usize, n: usize) -> Option<Vec<usize>> {
    let mut queue = VecDeque::new();
    let mut visited = vec![0; n + 1];
    queue.push_back(x);
    visited[x] = usize::MAX;

    for i in 1..=k {
        let cnt = queue.len();
        if cnt == 0 {
            return None;
        }
        
        for _ in 0..cnt {
            let node = queue.pop_front().unwrap();
            for &v in edges[node].iter() {
                if visited[v] > 0 {
                    continue;
                }

                visited[v] = i;
                queue.push_back(v);
            }
        }
    }

    let mut re = Vec::new();
    for i in 0..=n {
        if visited[i] == k {
            re.push(i);
        }
    }

    if re.len() > 0 {
        Some(re)
    } else {
        None
    }
}
