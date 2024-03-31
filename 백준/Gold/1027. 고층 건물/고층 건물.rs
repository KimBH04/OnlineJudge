use std::io::{stdin, Read};

fn main() {
    let mut buf = String::new();
    stdin().read_to_string(&mut buf).expect("input error");
    let mut input = buf.split_whitespace().flat_map(str::parse::<f64>);

    let n = input.next().unwrap() as usize;
    let mut tower = vec![0_f64; n];
    for i in 0..n {
        tower[i] = input.next().unwrap();
    }

    let mut max = 0;
    for i in 0..n {
        let mut cnt = 0;
        let mut diff = -1000000000_f64;
        for j in 1..=i {
            if tower[i - j] - tower[i] > diff * j as f64{
                cnt += 1;
                diff = (tower[i - j] - tower[i]) / j as f64;
            }
        }
        diff = -1000000000_f64;
        for j in 1..(n - i) {
            if tower[i + j] - tower[i] > diff * j as f64{
                cnt += 1;
                diff = (tower[i + j] - tower[i]) / j as f64;
            }
        }

        if max < cnt {
            max = cnt;
        }
    }

    println!("{max}");
}
