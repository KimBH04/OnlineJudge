use std::io::{Read, stdin};

// Store acts in 2d array
// Check loop with using 3d array
fn main() {
    const ASCII_A: usize = 65;

    let buf = &mut String::new();
    stdin().read_to_string(buf).expect("invalid input");
    let mut inputs = buf.split_ascii_whitespace();

    let mut state = inputs.next().unwrap().parse::<char>().unwrap() as usize - ASCII_A;
    let mut tape = 0;
    let mut pos = 0;
    let n = inputs.next().unwrap().parse::<usize>().unwrap();
    let l = inputs.next().unwrap().parse::<usize>().unwrap();
    let mut acts = Vec::new();
    let mut visited = Vec::new();
    for i in 0..16 {
        acts.push(Vec::from([(0, 0, 0), (0, 0, 0)]));
        visited.push(Vec::new());
        for j in 0..l {
            visited[i].push(Vec::new());
            for _ in 0..(1 << l) {
                visited[i][j].push(false);
            }
        }
    }
    for _ in 0..n {
        let state = inputs.next().unwrap().parse::<char>().unwrap() as usize - ASCII_A;
        let read = inputs.next().unwrap().parse::<usize>().unwrap();
        let over = inputs.next().unwrap().parse::<usize>().unwrap();
        let next = inputs.next().unwrap().parse::<char>().unwrap() as usize - ASCII_A;
        let mov = inputs.next().unwrap().parse::<isize>().unwrap();
        acts[state][read] = (over, next, mov);
    }
    let mut init_tape = inputs.next().unwrap().chars();
    for p in 0..l {
        let bit = init_tape.next().unwrap() as usize - 48;
        tape += bit << p;
    }

    while 0 <= pos && pos < l as isize {
        if visited[state][pos as usize][tape] {
            println!("CONTINUE");
            return;
        }

        visited[state][pos as usize][tape] = true;
        let mask = 1 << pos;
        let bit = tape & mask;
        let (over, next, mov) = acts[state][bit >> pos];
        if mov == 0 {
            break;
        }
        tape = (tape | mask) & (!mask | (over << pos)); 
        state = next;
        pos += mov;
    }
    println!("STOP");
}
