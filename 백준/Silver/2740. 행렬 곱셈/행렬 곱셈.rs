use std::io::{stdin, stdout, BufWriter, Read, Write};

fn main() {
    let mut buf = String::new();
    stdin().read_to_string(&mut buf).unwrap();
    let mut input = buf.split_whitespace().flat_map(str::parse::<i32>);

    let n = input.next().unwrap() as usize;
    let m = input.next().unwrap() as usize;
    let mut a = Vec::new();
    for i in 0..n {
        a.push(vec![0; m]);
        for j in 0..m {
            a[i][j] = input.next().unwrap();
        }
    }
    
    let m = input.next().unwrap() as usize;
    let k = input.next().unwrap() as usize;
    let mut b = Vec::new();
    for i in 0..m {
        b.push(vec![0; k]);
        for j in 0..k {
            b[i][j] = input.next().unwrap();
        }
    }

    let mut out = BufWriter::new(stdout().lock());
    let mut re = Vec::new();
    for i in 0..n {
        re.push(vec![0; k]);
        for j in 0..k {
            for k in 0..m {
                re[i][j] += a[i][k] * b[k][j];
            }
            write!(out, "{} ", re[i][j]).unwrap();
        }
        writeln!(out).unwrap();
    }
}
