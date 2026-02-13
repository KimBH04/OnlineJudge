use std::io::{Read, stdin};

fn main() {
    let buf = &mut String::new();
    stdin().read_to_string(buf).unwrap();
    let mut inputs = buf.split_ascii_whitespace();

    let x = inputs.next().unwrap().parse::<i128>().unwrap();
    let y = inputs.next().unwrap().parse::<i128>().unwrap();
    if (x, y) == (0, 0) {
        println!("-1");
        return;
    }

    // parsing
    let mut command = Vec::new();
    let mut stack = Vec::new();
    for c in inputs.next().unwrap().chars().rev() {
        if (c as usize) < 58 {
            stack.push(c);
        } else {
            stack.reverse();
            command.push((c, stack.iter().collect::<String>().parse::<usize>().unwrap()));
            stack.clear();
        }
    }

    let mut min = x * x + y * y;
    let mut min_x = 0;
    let mut min_y = 0;
    let mut current_x = 0;
    let mut current_y = 0;
    let mut current_dir = 0;
    const DIR: [(i128, i128); 4] = [(1, 0), (0, 1), (-1, 0), (0, -1)];
    for &(c, v) in command.iter().rev() {
        if c == 'T' {
            current_dir += v;
            current_dir %= 4;
            continue;
        }

        let (a_x, a_y) = DIR[current_dir];
        let to_x = current_x + a_x * v as i128;
        let to_y = current_y + a_y * v as i128;
        if current_x.min(to_x) < x && x < to_x.max(current_x) {
            let dis_y = y - to_y;
            if min > dis_y * dis_y {
                min = dis_y * dis_y;
                min_x = x;
                min_y = to_y;
            }
        } else if current_y.min(to_y) < y && y < to_y.max(current_y) {
            let dis_x = x - to_x;
            if min > dis_x * dis_x {
                min = dis_x * dis_x;
                min_x = to_x;
                min_y = y;
            }
        } else {    // Don't need current pos to conductor distance; got the value from previous loop (or init)
            let dis_x = x - to_x;
            let dis_y = y - to_y;
            let sqr_dis = dis_x * dis_x + dis_y * dis_y;
            if min > sqr_dis {
                min = sqr_dis;
                min_x = to_x;
                min_y = to_y;
            }
        }
        current_x = to_x;
        current_y = to_y;
        }
    if min == 0 {
        println!("-1");
    } else {
        println!("{min_x} {min_y}");
    }
}
