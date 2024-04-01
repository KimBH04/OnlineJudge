use std::{collections::VecDeque, io::{stdin, Read}};

fn main() {
    let mut buf = String::new();
    stdin().read_to_string(&mut buf).expect("input error");
    let mut input = buf.split_whitespace().flat_map(str::parse::<usize>);

    let n = input.next().unwrap();
    let k = input.next().unwrap();
    if n >= k {
        println!("{}\n1", n - k);
    } else {
        let mut visited = vec![0; 100001];
        visited[n] = 1;

        let mut queue = VecDeque::new();
        queue.push_front(n);

        let mut cnt = 0;
        'out_loop: while queue.len() > 0 {
            let mut temp = vec![0; 100001];
            for _ in 0..queue.len() {
                let x = queue.pop_back().unwrap();
                if x == k {
                    println!("{}\n{}", cnt, visited[x]);
                    break 'out_loop;
                }

                if x > 0 {
                    if temp[x - 1] == 0 {
                        queue.push_front(x - 1);
                    }
                    temp[x - 1] += visited[x];
                }
                if x < 100000 {
                    if temp[x + 1] == 0 {
                        queue.push_front(x + 1);
                    }
                    temp[x + 1] += visited[x];
                }
                if x < 50001 {
                    if temp[x * 2] == 0 {
                        queue.push_front(x * 2);
                    }
                    temp[x * 2] +=  visited[x];
                }
            }
            visited = temp;

            cnt += 1;
        }
    }
}
