use std::io::{stdin, Read};

const DIR: [(usize, usize); 8] = [(1, 2), (2, 2), (2, 1), (2, 0), (1, 0), (0, 0), (0, 1), (0, 2)];

fn main() {
    let mut buf = String::new();
    stdin().read_to_string(&mut buf).unwrap();
    let mut input = buf.split_whitespace().flat_map(str::parse::<usize>);

    let n = input.next().unwrap();
    let m = input.next().unwrap();
    let mut a = Vec::new();
    let mut clouds = Vec::new();
    let mut moved = Vec::new();
    for i in 0..n {
        a.push(vec![0; n]);
        clouds.push(vec![false; n]);
        moved.push(vec![false; n]);
        for j in 0..n {
            a[i][j] = input.next().unwrap();
        }
    }

    clouds[n - 2][0] = true;
    clouds[n - 1][0] = true;
    clouds[n - 2][1] = true;
    clouds[n - 1][1] = true;
    for _ in 0..m {
        let d = input.next().unwrap() - 1;
        let s = input.next().unwrap() % n;

        //move clouds
        let (r, c) = (DIR[d].0 * s, DIR[d].1 * s);
        for i in 0..n {
            for j in 0..n {
                moved[i][j] = clouds[(i + n + r - s) % n][(j + n + c - s) % n];
                if moved[i][j] {    //raining
                    a[i][j] += 1;
                }
            }
        }

        //magic of copy water
        let mut temp = Vec::new();
        for i in 0..n {
            temp.push(vec![0; n]);
            for j in 0..n {
                if moved[i][j] {
                    if i > 0 {
                        if j > 0 {
                            if a[i - 1][j - 1] > 0 {
                                temp[i][j] += 1;
                            }
                        }
                        if j < n - 1 {
                            if a[i - 1][j + 1] > 0 {
                                temp[i][j] += 1;
                            }
                        }
                    }
                    if i < n - 1 {
                        if j > 0 {
                            if a[i + 1][j - 1] > 0 {
                                temp[i][j] += 1;
                            }
                        }
                        if j < n - 1 {
                            if a[i + 1][j + 1] > 0 {
                                temp[i][j] += 1;
                            }
                        }
                    }
                }
            }
        }

        //create clouds
        for i in 0..n {
            for j in 0..n {
                a[i][j] += temp[i][j];
                clouds[i][j] = !moved[i][j] && a[i][j] > 1;
                if clouds[i][j] {
                    a[i][j] -= 2;
                }
            }
        }
    }

    let mut sum = 0;
    for row in a {
        for col in row {
            sum += col;
        }
    }

    println!("{sum}");
}