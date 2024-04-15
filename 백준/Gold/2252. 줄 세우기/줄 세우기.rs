use std::{collections::VecDeque, io::{stdin, stdout, BufWriter, Read, Write}};

fn main() {
    let buf = &mut String::new();
    stdin().read_to_string(buf).unwrap();
    let mut input = buf.split_whitespace().flat_map(str::parse::<usize>);

    let n = input.next().unwrap();
    let m = input.next().unwrap();
    let mut edges = Vec::new();
    let mut cnt = vec![0; n + 1];
    let mut visited = vec![false; n + 1];
    for _ in 0..=n {
        edges.push(Vec::new());
    }

    for _ in 0..m {
        let a = input.next().unwrap();
        let b = input.next().unwrap();
        edges[a].push(b);
        cnt[b] += 1;
    }

    let out = &mut BufWriter::new(stdout().lock());
    let mut queue = VecDeque::new();
    for i in 1..=n {
        if cnt[i] > 0 || visited[i] {
            continue;
        }
        queue.push_back(i);
        while let Some(j) = queue.pop_front() {
            if cnt[j] > 0 {
                cnt[j] -= 1;
                if cnt[j] > 0 {
                    continue;
                }
            }
            
            visited[j] = true;
            write!(out, "{j} ").unwrap();
            for &k in edges[j].iter() {
                if visited[k] {
                    continue;
                }
                queue.push_back(k);
            }
        }
    }
}
