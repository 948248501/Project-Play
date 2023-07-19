fn main() {
    // Greeting
    println!("Welcome to Project Play!");

    // Game Setup
    println!("Setting up game...");
    let mut board = [["A1", "A2", "A3"], ["B1", "B2", "B3"], ["C1", "C2", "C3"]];
    let mut score = [0, 0];
    let mut turn = 0; // 0 for player 1, 1 for player 2
    let mut winner = 0;
    let mut symbols = ["X", "O"];

    // Main Play Loop
    loop {
        // Check the win condition
        if (check_win(&board)) {
            winner = turn + 1;
            break;
        }

        // Get user input
        let mut input = String::new();
        println!("Player {}'s turn({}):", turn + 1, symbols[turn]);
        print!(">> ");
        io::stdin().read_line(&mut input)
            .expect("Error: Failed to read input");

        let input = input.trim();
        let position = parse_input(&input);

        // Validate input
        if !validate_input(&board, &position) {
            println!("Invalid input.");
            continue;
        } else {
            // Place mark
            board[position[0]][position[1]] = symbols[turn];

            // Switch turn
            turn = (turn + 1) % 2;
        }
    }

    // Print the final board and declare the winner
    println!("Player {} Wins!", winner);
    println!("Final Score:");
    println!("Player 1: {}", score[0]);
    println!("Player 2: {}", score[1]);
    println!("Final Board:");
    for row in board.iter() {
        println!("{} {} {}", row[0], row[1], row[2]);
    }
    println!("Game Over!");
}

fn check_win(board: &[&[&str]]) -> bool {
    let mut win = false;
    let mut check_list = [
        ["A1", "A2", "A3"], ["B1", "B2", "B3"], ["C1", "C2", "C3"],
        ["A1", "B1", "C1"], ["A2", "B2", "C2"], ["A3", "B3", "C3"],
        ["A1", "B2", "C3"], ["A3", "B2", "C1"]
    ];

    for check in check_list.iter() {
        if board[0][0] == check[0] && board[1][1] == check[1] && board[2][2] == check[2] {
            win = true;
            break;
        }
    }

    return win;
}

fn parse_input(input: &str) -> [usize; 2] {
    let row: usize = input.chars().nth(0).unwrap() as usize - 0x41;
    let column: usize = input.chars().nth(1).unwrap() as usize - 0x31;

    return [row, column];
}

fn validate_input(board: &[&[&str]], position: &[usize; 2]) -> bool {
    let mut valid = true;
    if position[0] > 2 || position[1] > 2 {
        valid = false;
    } else if board[position[0]][position[1]] != "-" {
        valid = false;
    }

    return valid;
}