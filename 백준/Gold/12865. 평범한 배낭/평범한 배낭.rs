use std::io::{stdin, Read};

fn main() {
    let mut buf = String::new();
    stdin().read_to_string(&mut buf).expect("input error");
    let mut input = buf.split_whitespace().flat_map(str::parse::<usize>);

    let n = input.next().unwrap();
    let k = input.next().unwrap();
    let mut things = Vec::new();
    for _ in 0..n {
        let w = input.next().unwrap();
        let v = input.next().unwrap();
        things.push((w, v));
    }
    things.sort();

    let mut knapsack = Vec::from([vec![0; k + 1]]);
    for i in 1..=n {
        knapsack.push(vec![0; k + 1]);
        for w in 1..=k {
            let thing = things[i - 1];
            knapsack[i][w] = if w < thing.0 || knapsack[i - 1][w - thing.0] + thing.1 < knapsack[i - 1][w] {
                knapsack[i - 1][w]
            } else {
                knapsack[i - 1][w - thing.0] + thing.1
            }
        }
    }

    print!("{}", knapsack[n][k]);
}
