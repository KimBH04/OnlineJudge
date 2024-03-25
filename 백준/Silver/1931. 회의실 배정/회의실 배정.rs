use std::io::{stdin, Read};

fn main() {
    let mut buffer = String::new();
    stdin().read_to_string(&mut buffer).expect("input panic");
    let mut input = buffer.split_whitespace().flat_map(str::parse::<usize>);

    let n = input.next().unwrap();
    let mut meetings = vec![(0, 0); n];
    for i in 0..n {
        let s = input.next().unwrap();
        let e = input.next().unwrap();
        meetings[i] = (s, e);
    }
    meetings.sort();

    let mut cnt = 1;
    let mut meeting = meetings[0];
    for i in 1..n {
        let (s, e) = meetings[i];
        if meeting.0 <= s && s < meeting.1 {
            if e < meeting.1 {
                meeting = (s, e);
            }
        }
        else {
            meeting = (s, e);
            cnt += 1;
        }
    }

    print!("{}", cnt);
}
