use std::io::{stdin, BufRead, BufReader};

fn main() {
    let mut reader = BufReader::new(stdin().lock());
    
    let buf = &mut String::new();
    reader.read_line(buf).unwrap();

    let v = buf.trim().parse().unwrap();
    let mut nodes = vec![Vec::new(); v + 1];
    for _ in 0..v {
        let line = &mut String::new();
        reader.read_line(line).unwrap();

        let mut input = line.split_whitespace().flat_map(str::parse::<usize>);
        let n = input.next().unwrap();
        while let Some(x) = input.next() {
            nodes[n].push((x, input.next().unwrap()));
        }
    }

    let mut max = 0;
    let dis = dfs(&nodes, &mut vec![false; v + 1], &mut max, 1);
    println!("{}", if dis > max { dis } else { max });
}

fn dfs(nodes: &Vec<Vec<(usize, usize)>>, visited: &mut Vec<bool>, max: &mut usize, n: usize) -> usize {
    visited[n] = true;
    let mut a = 0;
    let mut b = 0;
    for (v, d) in nodes[n].clone() {
        if visited[v] {
            continue;
        }

        // 탐색을 해 얻은 길이 정렬
        let dis = dfs(nodes, visited, max, v) + d;
        if a < dis {
            b = a;
            a = dis;
        } else if b < dis {
            b = dis;
        }
    }

    // 자식 노드 중 가장 긴 두 길이의 합을 최종 길이와 비교
    let c = a + b;
    if *max < c {
        *max = c;
    }

    a   // 가장 긴 길이 반환
}