use std::io::{stdin, Read};

fn main() {
    let mut buffer = String::new();
    stdin().read_to_string(&mut buffer).expect("scan panic");
    let mut input = buffer.split_whitespace().flat_map(str::parse::<usize>);

    let k = input.next().expect("get usize panic");
    let mut cnt: usize = 0;

    const MAX: usize = 7368788;
    let mut arr = vec![true; MAX];
    arr[0] = false;
    arr[1] = false;
    for i in 0..MAX {
        if arr[i] {
            cnt += 1;
            if cnt == k {
                print!("{}", i);
                break;
            }

            let mut j = i + i;
            while j < MAX {
                arr[j] = false;
                j += i;
            }
        }
    }
}
